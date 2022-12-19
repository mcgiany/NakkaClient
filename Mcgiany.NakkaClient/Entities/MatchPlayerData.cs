using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class MatchPlayerData
{
    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("left")]
    public int Left { get; set; }
}
