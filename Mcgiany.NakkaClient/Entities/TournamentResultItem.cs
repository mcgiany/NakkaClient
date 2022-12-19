using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class TournamentResultItem
{
    [JsonPropertyName("tmid")]
    public string MatchId { get; set; } = null!;

    [JsonPropertyName("startTime")]
    public long StartTime { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("endMatch")]
    public int EndMatch { get; set; }

    [JsonPropertyName("p1tpid")]
    public string Player1Id { get; set; } = null!;

    [JsonPropertyName("p1name")]
    public string Player1Name { get; set; } = null!;

    [JsonPropertyName("p2tpid")]
    public string Player2Id { get; set; } = null!;

    [JsonPropertyName("p2name")]
    public string Player2Name { get; set; } = null!;

    [JsonPropertyName("p1winLegs")]
    public int Player1WinLegs { get; set; }

    [JsonPropertyName("p2winLegs")]
    public int Player2WinLegs { get; set; }

    [JsonPropertyName("p1allScore")]
    public int Player1AllScore { get; set; }

    [JsonPropertyName("p1allDarts")]
    public int Player1AllDarts { get; set; }

    [JsonPropertyName("p2allScore")]
    public int Player2AllScore { get; set; }

    [JsonPropertyName("p2allDarts")]
    public int Player2AllDarts { get; set; }
}
