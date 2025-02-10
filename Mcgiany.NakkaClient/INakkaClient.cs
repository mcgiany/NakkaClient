using Mcgiany.NakkaClient.Entities;
using Mcgiany.NakkaClient.Enums;

namespace Mcgiany.NakkaClient;

/// <summary>
/// Nakka client.
/// </summary>
public interface INakkaClient
{
    /// <summary>
    /// Get Nakka league by ID.
    /// </summary>
    /// <param name="leagueId">League ID.</param>
    /// <returns><see cref="NakkaLeague"/></returns>
    Task<NakkaLeague?> GetLeagueAsync(string leagueId);

    /// <summary>
    /// Get season list - tournaments of the league.
    /// </summary>
    /// <param name="leagueId">League ID.</param>
    /// <param name="skip">Skip items.</param>
    /// <param name="count">Number of returned items.</param>
    /// <param name="statuses">Filter status.</param>
    /// <param name="keyword">Filter keyword.</param>
    /// <param name="sort">Sort key.</param>
    /// <returns><see cref="NakkaRound"/></returns>
    Task<List<NakkaRound>?> GetSeasonListAsync(string leagueId, int skip, int count, NakkaStatus[] statuses, string keyword = "", string sort = "date");

    /// <summary>
    /// Get tournamen by ID.
    /// </summary>
    /// <param name="tournamentId">Tournament ID.</param>
    /// <returns><see cref="NakkaTournament"/></returns>
    Task<NakkaTournament?> GetTournamentAsync(string tournamentId);

    /// <summary>
    /// Get list of players in tournament.
    /// </summary>
    /// <param name="tournamentId">Tournament ID.</param>
    /// <returns><see cref="NakkaPlayer"/></returns>
    Task<List<NakkaPlayer>?> GetTournamentPlayersAsync(string tournamentId);

    /// <summary>
    /// Get tournament statistics.
    /// </summary>
    /// <param name="tournamentId">Tournament ID.</param>
    /// <returns>Dictionary of player tournament statistics where dictionary key is player ID.</returns>
    Task<Dictionary<string, PlayerTournamentStats>?> GetTournamentStatsAsync(string tournamentId);

    /// <summary>
    /// Get tournamen results - list of tournament matches.
    /// </summary>
    /// <param name="tournamentId">Tournament ID.</param>
    /// <param name="skip">Skip items.</param>
    /// <param name="count">Number of returned items.</param>
    /// <param name="name">Filter by name.</param>
    /// <returns><see cref="TournamentResults"/></returns>
    Task<TournamentResults?> GetTournamentResultsAsync(string tournamentId, int skip = 0, int count = 30, string name = "");

    /// <summary>
    /// Get match by ID.
    /// </summary>
    /// <param name="matchId">Match ID.</param>
    /// <returns><see cref="NakkaMatch"/></returns>
    Task<NakkaMatch?> GetMatchAsync(string matchId);

    /// <summary>
    /// Get tournament package (Tournament, Player list and Statistics).
    /// </summary>
    /// <param name="tournamentId">Tournament ID.</param>
    /// <returns></returns>
    Task<TournamentPackage> GetTournamentPackageAsync(string tournamentId);
}
