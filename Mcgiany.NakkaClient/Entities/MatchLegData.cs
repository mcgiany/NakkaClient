using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class MatchLegData
{
    [JsonPropertyName("time")]
    public long Time { get; set; }

    [JsonPropertyName("first")]
    public int First { get; set; }

    [JsonPropertyName("currentRound")]
    public int CurrentRound { get; set; }

    [JsonPropertyName("currentPlayer")]
    public int CurrentPlayer { get; set; }

    [JsonPropertyName("selectRound")]
    public int SelectRound { get; set; }

    [JsonPropertyName("selectPlayer")]
    public int SelectPlayer { get; set; }

    [JsonPropertyName("endFlag")]
    public int EndFlag { get; set; }

    [JsonPropertyName("middleForDiddle")]
    public int MiddleForDiddle { get; set; }

    [JsonPropertyName("winner")]
    public int Winner { get; set; }

    [JsonPropertyName("playerData")]
    public MatchPlayerData[][] PlayerData { get; set; } = null!;
}
