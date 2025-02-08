using Mcgiany.NakkaClient.Entities;

namespace Mcgiany.NakkaClient;

public class TournamentPackage
{
    internal TournamentPackage(
        NakkaTournament tournament,
        Dictionary<string, PlayerTournamentStats> playerTournamentStats,
        List<NakkaPlayer> tournamentPlayers)
    {
        ArgumentNullException.ThrowIfNull(tournament);
        ArgumentNullException.ThrowIfNull(playerTournamentStats);
        ArgumentNullException.ThrowIfNull(tournamentPlayers);
        Tournament = tournament;
        PlayerTournamentStats = playerTournamentStats;
        TournamentPlayers = tournamentPlayers;
    }

    public NakkaTournament Tournament { get; }
    
    public Dictionary<string, PlayerTournamentStats> PlayerTournamentStats { get; }

    public List<NakkaPlayer> TournamentPlayers { get; set; }


    /// <summary>
    /// Build round robin groups with calculating player rank.
    /// </summary>
    /// <returns>List of round robin groups.</returns>
    public List<RoundRobinGroup> BuildRoundRobinGroups()
    {
        var groups = new List<RoundRobinGroup>();
        foreach (var rrResult in Tournament.RoundRobinResults)
        {
            var validEntry = rrResult.First(x => Tournament.EntryList.Select(s => s.PlayerId).Contains(x.Key));
            var groupNumber = PlayerTournamentStats[validEntry.Key].Group;
            groups.Add(BuildRoundRobinGroup(rrResult, groupNumber, Tournament.RobinRoundRank));
        }
        return groups;
    }

    private RoundRobinGroup BuildRoundRobinGroup(Dictionary<string, Dictionary<string, GameScore>> rrResult, int groupNumber,
        List<Dictionary<string, int>> robinRoundRank)
    {
        var group = new RoundRobinGroup
        {
            Number = groupNumber,
        };
        var groupMatches = new List<GroupMatch>();
        foreach (var player in rrResult)
        {
            foreach (var opponent in player.Value)
            {
                if (opponent.Value.LegsWin is null)
                {
                    continue;
                }
                var match = new GroupMatch
                {
                    Player = player.Key,
                    Opponent = opponent.Key,
                    Average = opponent.Value.Average,
                    PlayerScore = opponent.Value.LegsWin.Value
                };
                groupMatches.Add(match);
            }
        }
        foreach (var player in rrResult)
        {
            foreach (var opponent in player.Value)
            {
                var reverseMatch = groupMatches.Where(x => x.Player == opponent.Key && x.Opponent == player.Key).FirstOrDefault();
                if (reverseMatch != null)
                {
                    reverseMatch.OpponentScore = opponent.Value.LegsWin.Value;
                }
            }
        }
        var forcedRanks = new Dictionary<string, int>();
        if (robinRoundRank is not null)
        {
            foreach (var groupRanks in robinRoundRank.Where(x => x != null))
            {
                foreach (var groupRank in groupRanks)
                {
                    forcedRanks.Add(groupRank.Key, groupRank.Value);
                }
            }
        }
        group.Players = groupMatches
            .GroupBy(x => x.Player)
            .Select(x => new RoundRobinGroupPlayer
            {
                Player = x.Key,
                Wins = x.Count(w => w.PlayerScore > w.OpponentScore),
                Points = x.Count(m => m.PlayerScore > m.OpponentScore) * Tournament.RoundRobinSettings.PointWin + x.Count(m => m.PlayerScore == m.OpponentScore) * Tournament.RoundRobinSettings.PointDraw,
                WinLegs = x.Sum(l => l.PlayerScore),
                LostLegs = x.Sum(l => l.OpponentScore),
                BestAvg = x.Max(a => a.Average),
                ForcedRank = forcedRanks.ContainsKey(x.Key) ? forcedRanks[x.Key] : 0,
            }).ToList();
        var rank = 1;
        RoundRobinGroupPlayer? previousStats = null;
        foreach (var player in group.Players.OrderByDescending(x => x.Points).ThenByDescending(x => x.LegDiff).ThenBy(x => x.ForcedRank))
        {
            if (previousStats == null || previousStats.Points != player.Points ||
            previousStats.LegDiff != player.LegDiff || previousStats.ForcedRank != player.ForcedRank)
            {
                player.Rank = rank;
            }
            else
            {
                var mutualMatch = groupMatches.Single(x => x.Player == player.Player && x.Opponent == previousStats.Player);
                if (mutualMatch.PlayerScore == mutualMatch.OpponentScore)
                {
                    player.Rank = previousStats.Rank;
                }
                if (mutualMatch.PlayerScore >= mutualMatch.OpponentScore)
                {
                    player.Rank = previousStats.Rank;
                    previousStats.Rank++;
                }
                if (mutualMatch.PlayerScore < mutualMatch.OpponentScore)
                {
                    player.Rank = rank;
                }
            }
            previousStats = player;
            rank++;
        }

        return group;
    }
}
