namespace Mcgiany.NakkaClient.Entities;

public struct NakkaMatchId : IEquatable<NakkaMatchId>
{
    public string TournamentId { get; set; }

    public readonly TournamentPhase Phase => PhaseString switch
    {
        "rr" => TournamentPhase.RoundRobin,
        "t" => TournamentPhase.Knockout,
        _ => TournamentPhase.Unknown
    };

    public string PhaseString { get; set; }

    public int PhaseNumber { get; set; }

    public string Player1 { get; set; }

    public string Player2 { get; set; }

    public string MatchId { get; set; }

    public NakkaMatchId(string tournamentId, string matchId)
    {
        TournamentId = tournamentId;
        var matchData = matchId.Replace($"{tournamentId}_", "").Split('_');
        PhaseString = matchData[0];
        PhaseNumber = int.Parse(matchData[1]);
        Player1 = matchData[2];
        Player2 = matchData[3];
        MatchId = matchId;
    }

    public static bool operator ==(NakkaMatchId first, NakkaMatchId second)
    {
        return first.TournamentId == second.TournamentId &&
        first.PhaseString == second.PhaseString &&
        first.PhaseNumber == second.PhaseNumber &&
        (first.Player1 == second.Player1 && first.Player2 == second.Player2 || first.Player1 == second.Player2 && first.Player2 == second.Player1);
    }

    public static bool operator !=(NakkaMatchId first, NakkaMatchId second)
    {
        return first.TournamentId != second.TournamentId ||
        first.PhaseString != second.PhaseString ||
        first.PhaseNumber != second.PhaseNumber ||
        (first.Player1 != second.Player1 || first.Player2 != second.Player2)
        && (first.Player1 != second.Player2 || first.Player2 != second.Player1);
    }

    public bool Equals(NakkaMatchId other)
    {
        return TournamentId == other.TournamentId &&
        PhaseString == other.PhaseString &&
        PhaseNumber == other.PhaseNumber &&
        (Player1 == other.Player1 && Player2 == other.Player2 || Player1 == other.Player2 && Player2 == other.Player1);
    }

    public override bool Equals(object? obj)
    {
        return obj is NakkaMatchId id && Equals(id);
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + (TournamentId?.GetHashCode() ?? 0);
        hash = hash * 23 + (PhaseString?.GetHashCode() ?? 0);
        hash = hash * 23 + PhaseNumber.GetHashCode();

        // Aby bol hash rovnaký pre (Player1, Player2) a (Player2, Player1)
        var orderedPlayers = new[] { Player1, Player2 };
        Array.Sort(orderedPlayers);

        hash = hash * 23 + (orderedPlayers[0]?.GetHashCode() ?? 0);
        hash = hash * 23 + (orderedPlayers[1]?.GetHashCode() ?? 0);

        return hash;
    }
}
