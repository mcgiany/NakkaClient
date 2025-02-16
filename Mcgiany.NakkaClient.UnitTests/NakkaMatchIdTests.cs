using Mcgiany.NakkaClient.Entities;
using Xunit;

namespace Mcgiany.NakkaClient.UnitTests;

public class NakkaMatchIdTests
{
    [Fact]
    public void EqualOperatorTest()
    {
        var matchId1 = new NakkaMatchId("t_rA0I_9800", "t_rA0I_9800_rr_4_L25O_hLrx");
        var matchId2 = new NakkaMatchId("t_rA0I_9800", "t_rA0I_9800_rr_4_L25O_hLrx");
        var matchId3 = new NakkaMatchId("t_rA0I_9800", "t_rA0I_9800_rr_4_hLrx_L25O");

        Assert.True(matchId1 == matchId2);
        Assert.True(matchId2 == matchId3);
        Assert.True(matchId1.Equals(matchId2));
        Assert.True(matchId2.Equals(matchId3));
    }

    [Fact]
    public void NotEqualOperatorTest()
    {
        var matchId1 = new NakkaMatchId("t_rA0I_9800", "t_rA0I_9800_rr_4_L25O_hLrx");
        var matchId2 = new NakkaMatchId("t_rA0I_9800", "t_rA0I_9800_rr_4_L25O_hLrz");
        var matchId3 = new NakkaMatchId("t_rA0I_9800", "t_rA0I_9800_rr_4_L251_hLrx");
        var matchId4 = new NakkaMatchId("t_rA0I_9800", "t_rA0I_9800_rr_5_L25O_hLrx");
        var matchId5 = new NakkaMatchId("t_rA0I_9800", "t_rA0I_9800_t_4_L25O_hLrx");
        var matchId6 = new NakkaMatchId("t_rA0I_9801", "t_rA0I_9801_rr_4_L25O_hLrx");

        Assert.True(matchId1 != matchId2);
        Assert.True(matchId1 != matchId3);
        Assert.True(matchId1 != matchId4);
        Assert.True(matchId1 != matchId5);
        Assert.True(matchId1 != matchId6);
    }

    [Fact]
    public void ParseTest()
    {
        var matchId1 = new NakkaMatchId("t_rA0I_9800", "t_rA0I_9800_rr_4_L25O_hLrx");
        Assert.Equal("t_rA0I_9800", matchId1.TournamentId);
        Assert.Equal("t_rA0I_9800_rr_4_L25O_hLrx", matchId1.MatchId);
        Assert.Equal("rr", matchId1.PhaseString);
        Assert.Equal(TournamentPhase.RoundRobin, matchId1.Phase);
        Assert.Equal(4, matchId1.PhaseNumber);
        Assert.Equal("L25O", matchId1.Player1);
        Assert.Equal("hLrx", matchId1.Player2);
    }
}
