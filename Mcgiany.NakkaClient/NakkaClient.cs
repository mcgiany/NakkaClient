using Mcgiany.NakkaClient.Entities;
using Mcgiany.NakkaClient.Enums;
using Mcgiany.NakkaClient.Request;

namespace Mcgiany.NakkaClient;

/// <summary>
/// Implementation of <see cref="INakkaClient"/>
/// </summary>
public class NakkaClient : INakkaClient, IDisposable
{
    private readonly IRestClient _restClient;

    public NakkaClient(IRestClient restClient)
    {
        ArgumentNullException.ThrowIfNull(restClient);
        _restClient = restClient;
    }

    public async Task<NakkaLeague?> GetLeagueAsync(string leagueId)
    {
        var request = new GetLeagueRequest { LeagueId = leagueId };
        var league = await _restClient.PostAsync<GetLeagueRequest, NakkaLeague>("league/n01_league.php?cmd=get_lg_data", request);
        return league;
    }

    public async Task<List<NakkaRound>?> GetSeasonListAsync(string leagueId, int skip, int count, NakkaStatus[] statuses, string keyword = "", string sort = "date")
    {
        var request = new GetSeasonListRequest
        {
            Skip = skip,
            Count = count,
            Statuses = statuses,
            Keyword = keyword,
            Sort = sort,
        };
        var rounds = await _restClient.PostAsync<GetSeasonListRequest, List<NakkaRound>>($"league/n01_league.php?cmd=get_season_list&lgid={leagueId}", request);
        return rounds;
    }

    public async Task<NakkaTournament?> GetTournamentAsync(string tournamentId)
    {
        var request = new GetTournamentRequest { TournamentId = tournamentId };
        var tournament = await _restClient.PostAsync<GetTournamentRequest, InternalNakkaTournament>("tournament/n01_tournament.php?cmd=get_data", request);
        if (tournament is null)
        {
            return null;
        }
        return new NakkaTournament(tournament);
    }

    public async Task<List<NakkaPlayer>?> GetTournamentPlayersAsync(string tournamentId)
    {
        var players = await _restClient.GetAsync<List<NakkaPlayer>>($"tournament/n01_tournament.php?cmd=get_entry_list&tdid={tournamentId}");
        return players;
    }

    public async Task<Dictionary<string, PlayerTournamentStats>?> GetTournamentStatsAsync(string tournamentId)
    {
        var stats = await _restClient.GetAsync<Dictionary<string, PlayerTournamentStats>>($"tournament/n01_stats_t.php?cmd=stats_list&tdid={tournamentId}");
        return stats;
    }

    public async Task<TournamentResults?> GetTournamentResultsAsync(string tournamentId, int skip = 0, int count = 30, string name = "")
    {
        var results = await _restClient.GetAsync<TournamentResults>($"tournament/n01_history.php?cmd=get_t_list&tdid={tournamentId}&skip={skip}&count={count}&name={name}");
        return results;
    }

    public async Task<NakkaMatch?> GetMatchAsync(string matchId)
    {
        var request = new GetMatchRequest { MatchId = matchId };
        var match = await _restClient.PostAsync<GetMatchRequest, NakkaMatch>($"tournament/n01_user_t.php?cmd=match_view&sid=", request);
        return match;
    }

    public async Task<TournamentPackage> GetTournamentPackageAsync(string tournamentId)
    {
        var tournament = await GetTournamentAsync(tournamentId);
        if (tournament is null)
        {
            throw new InvalidOperationException("Tournament does not exist.");
        }
        var stats = await GetTournamentStatsAsync(tournamentId);
        if (stats is null)
        {
            throw new InvalidOperationException("Tournament does not exist.");
        }
        var players = await GetTournamentPlayersAsync(tournamentId);
        if (players is null)
        {
            throw new InvalidOperationException("Tournament does not exist.");
        }
        return new TournamentPackage(tournament, stats, players);
    }

    public void Dispose()
    {
        _restClient?.Dispose();
    }

    public async Task<Dictionary<string, NakkaMatchId>> GetLiveMatchesAsync(string tournamentId)
    {
        var matches = await _restClient.GetAsync<List<string>>($"tournament/n01_tournament.php?cmd=get_live_list&tdid={tournamentId}");
        if (matches is null)
        {
            return [];
        }
        return matches.ToDictionary(k => k, v => new NakkaMatchId(tournamentId, v));
    }
}
