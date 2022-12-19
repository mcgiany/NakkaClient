using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class GameSettings
{
    [JsonPropertyName("round")]
    public int Round { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("limit_leg_count")]
    public int LimitLegCount { get; set; }

    [JsonPropertyName("limit_set_count")]
    public int LimitSetCount { get; set; }

    [JsonPropertyName("limit_set_leg_count")]
    public int LimitSetLegCount { get; set; }
}
