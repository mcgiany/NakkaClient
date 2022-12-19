using Mcgiany.NakkaClient.Enums;
using Xunit;

namespace Mcgiany.NakkaClient.UnitTests;

public class ProviderTests
{
    private const string NakkaUrl = "https://tk2-228-23746.vs.sakura.ne.jp/n01";
    [Fact]
    public async Task GetLeagueTestAsync()
    {
        using var nakkaProvider = new ApiClient(NakkaUrl);
        var league = await nakkaProvider.GetLeagueAsync("lg_4Hoz_9377");
        Assert.NotNull(league);
    }

    [Fact]
    public async Task GetSeasonListTestAsync()
    {
        using var nakkaProvider = new ApiClient(NakkaUrl);
        var rounds = await nakkaProvider.GetSeasonListAsync("lg_4Hoz_9377", 0, 10, new[] { NakkaStatus.Completed });
        Assert.Equal(10, rounds.Count);
    }

    [Fact]
    public async Task GetTournamentTestAsync()
    {
        using var nakkaProvider = new ApiClient(NakkaUrl);
        var tournament = await nakkaProvider.GetTournamentAsync("t_A8wg_4484");
        Assert.NotNull(tournament);
    }

    [Fact]
    public async Task GetTournamentPlayersTestAsync()
    {
        using var nakkaProvider = new ApiClient(NakkaUrl);
        var players = await nakkaProvider.GetTournamentPlayersAsync("t_A8wg_4484");
        Assert.True(players.Any());
    }

    [Fact]
    public async Task GetTournamentStatsTestAsync()
    {
        using var nakkaProvider = new ApiClient(NakkaUrl);
        var stats = await nakkaProvider.GetTournamentStatsAsync("t_A8wg_4484");
        Assert.True(stats.Any());
    }

    [Fact]
    public async Task GetTournamentResultsTestAsync()
    {
        using var nakkaProvider = new ApiClient(NakkaUrl);
        var results = await nakkaProvider.GetTournamentResultsAsync("t_A8wg_4484");
        Assert.Equal(30, results.List.Length);
    }

    [Fact]
    public async Task GetMatchTestAsync()
    {
        using var nakkaProvider = new ApiClient(NakkaUrl);
        var match = await nakkaProvider.GetMatchAsync("t_A8wg_4484_t_3_9aTi_ILHq");
        Assert.NotNull(match);
    }
}
