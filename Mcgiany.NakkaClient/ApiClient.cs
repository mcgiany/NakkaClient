using Mcgiany.NakkaClient.Entities;
using Mcgiany.NakkaClient.Enums;
using Mcgiany.NakkaClient.Http;
using Mcgiany.NakkaClient.Request;

namespace Mcgiany.NakkaClient;

/// <summary>
/// ApiClient implementation of <see cref="INakkaClient"/>
/// </summary>
public class ApiClient : INakkaClient, IDisposable
{
    private readonly string _baseUrl;

    private readonly RestClient _restClient;

    public ApiClient(string baseUrl)
    {
        ArgumentNullException.ThrowIfNull(baseUrl);
        _baseUrl = baseUrl.TrimEnd('/');
        _restClient = new RestClient();
    }

    public async Task<NakkaLeague?> GetLeagueAsync(string leagueId)
    {
        var request = new GetLeagueRequest { LeagueId = leagueId };
        var league = await _restClient.PostAsync<GetLeagueRequest, NakkaLeague>(_baseUrl + "/league/n01_league.php?cmd=get_lg_data", request);
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
        var rounds = await _restClient.PostAsync<GetSeasonListRequest, List<NakkaRound>>(_baseUrl + $"/league/n01_league.php?cmd=get_season_list&lgid={leagueId}", request);
        return rounds;
    }

    public async Task<NakkaTournament?> GetTournamentAsync(string tournamentId)
    {
        var request = new GetTournamentRequest { TournamentId = tournamentId };
        var tournament = await _restClient.PostAsync<GetTournamentRequest, NakkaTournament>(_baseUrl + "/tournament/n01_tournament.php?cmd=get_data", request);
        return tournament;
    }

    public async Task<List<Player>?> GetTournamentPlayersAsync(string tournamentId)
    {
        var players = await _restClient.GetAsync<List<Player>>(_baseUrl + $"/tournament/n01_tournament.php?cmd=get_entry_list&tdid={tournamentId}");
        return players;
    }

    public async Task<Dictionary<string, PlayerTournamentStats>?> GetTournamentStatsAsync(string tournamentId)
    {
        var stats = await _restClient.GetAsync<Dictionary<string, PlayerTournamentStats>>(_baseUrl + $"/tournament/n01_stats_t.php?cmd=stats_list&tdid={tournamentId}");
        return stats;
    }

    public async Task<TournamentResults?> GetTournamentResultsAsync(string tournamentId, int skip = 0, int count = 30, string name = "")
    {
        var results = await _restClient.GetAsync<TournamentResults>(_baseUrl + $"/tournament/n01_history.php?cmd=get_t_list&tdid={tournamentId}&skip={skip}&count={count}&name={name}");
        return results;
    }

    public async Task<Match?> GetMatchAsync(string matchId)
    {
        var request = new GetMatchRequest { MatchId = matchId };
        var match = await _restClient.PostAsync<GetMatchRequest, Match>(_baseUrl + $"/tournament/n01_user_t.php?cmd=match_view&sid=", request);
        return match;
    }

    public void Dispose()
    {
        _restClient?.Dispose();
    }
}
