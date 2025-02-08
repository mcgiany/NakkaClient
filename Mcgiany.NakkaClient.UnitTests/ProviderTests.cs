using Mcgiany.NakkaClient.Enums;
using Mcgiany.NakkaClient.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Mcgiany.NakkaClient.UnitTests;

public class ProviderTests
{
    private const string NakkaUrl = "https://tk2-228-23746.vs.sakura.ne.jp/n01";
    private INakkaClient _nakkaClient;

    public ProviderTests()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddNakkaClient();
        var serviceProvider = serviceCollection.BuildServiceProvider();
        _nakkaClient = serviceProvider.GetService<INakkaClient>();
    }

    [Fact]
    public async Task TestRRRankDeserializationAsync()
    {
        var tournament = await _nakkaClient.GetTournamentAsync("t_op3x_4712");
        var ranks = tournament.RobinRoundRank;
        Assert.True(ranks.Count > 0);
    }

    [Fact]
    public async Task GetLeagueTestAsync()
    {
        var league = await _nakkaClient.GetLeagueAsync("lg_4Hoz_9377");
        Assert.NotNull(league);
    }

    [Fact]
    public async Task GetSeasonListTestAsync()
    {
        var rounds = await _nakkaClient.GetSeasonListAsync("lg_4Hoz_9377", 0, 10, new[] { NakkaStatus.Completed });
        Assert.Equal(10, rounds?.Count);
    }

    [Fact]
    public async Task GetTournamentTestAsync()
    {
        var tournament = await _nakkaClient.GetTournamentAsync("t_oEuf_6721");
        Assert.NotNull(tournament);
    }

    [Fact]
    public async Task GetTournamentPlayersTestAsync()
    {
        var players = await _nakkaClient.GetTournamentPlayersAsync("t_A8wg_4484");
        Assert.True(players?.Any());
    }

    [Fact]
    public async Task GetTournamentStatsTestAsync()
    {
        var stats = await _nakkaClient.GetTournamentStatsAsync("t_A8wg_4484");
        Assert.True(stats?.Any());
    }

    [Fact]
    public async Task GetTournamentResultsTestAsync()
    {
        var results = await _nakkaClient.GetTournamentResultsAsync("t_A8wg_4484");
        Assert.Equal(30, results?.List.Length);
    }

    [Fact]
    public async Task GetMatchTestAsync()
    {
        var match = await _nakkaClient.GetMatchAsync("t_A8wg_4484_t_3_9aTi_ILHq");
        Assert.NotNull(match);
    }
}
