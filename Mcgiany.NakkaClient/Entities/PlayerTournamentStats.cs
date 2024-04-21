using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class PlayerTournamentStats
{
    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("darts")]
    public int Darts { get; set; }

    [JsonPropertyName("winLeg")]
    public int LegsWin { get; set; }

    [JsonPropertyName("leg")]
    public int LegPlayed { get; set; }

    [JsonPropertyName("a_b")]
    public int A_b { get; set; }

    [JsonPropertyName("w_b")]
    public int W_b { get; set; }

    [JsonPropertyName("winSet")]
    public int SetsWin { get; set; }

    [JsonPropertyName("set")]
    public int SetsPlayed { get; set; }

    [JsonPropertyName("ton00")]
    public int Ton00Count { get; set; }

    [JsonPropertyName("ton40")]
    public int Ton40Count { get; set; }

    [JsonPropertyName("ton70")]
    public int Ton70Count { get; set; }

    [JsonPropertyName("ton80")]
    public int Ton80Count { get; set; }

    [JsonPropertyName("highOut")]
    public int HighestCheckout { get; set; }

    [JsonPropertyName("highOutCount")]
    public int HighOutCount { get; set; }

    [JsonPropertyName("best")]
    public int BestLeg { get; set; }

    [JsonPropertyName("worst")]
    public int WorstLeg { get; set; }

    [JsonPropertyName("winDarts")]
    public int WinDarts { get; set; }

    [JsonPropertyName("winCnt")]
    public int WinCnt { get; set; }

    [JsonPropertyName("f9Score")]
    public int FirstNineScore { get; set; }

    [JsonPropertyName("f9Darts")]
    public int FirstNineDarts { get; set; }

    [JsonPropertyName("r_g")]
    public int Group { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("rank_s2")]
    public int RankS2 { get; set; }

    [JsonPropertyName("a")]
    public int A { get; set; }

    [JsonPropertyName("acnt")]
    public int Acnt { get; set; }
}
