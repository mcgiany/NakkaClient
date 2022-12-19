using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class GameScore
{
    [JsonPropertyName("r")]
    public int LegsWin { get; set; }

    [JsonPropertyName("a")]
    public decimal Average { get; set; }
}
