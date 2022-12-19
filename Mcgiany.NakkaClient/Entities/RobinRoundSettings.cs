using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class RoundRobinSettings
{
    [JsonPropertyName("round_robin")]
    public int RoundRobin { get; set; }

    [JsonPropertyName("robin_count")]
    public int RobinCount { get; set; }

    [JsonPropertyName("robin_player_count")]
    public int RobinPlayerCount { get; set; }

    [JsonPropertyName("show_order")]
    public int ShowOrder { get; set; }

    [JsonPropertyName("include_leg")]
    public int IncludeLeg { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("limit_leg_count")]
    public int LimitLegCount { get; set; }

    [JsonPropertyName("drawMode")]
    public int DrawMode { get; set; }

    [JsonPropertyName("limit_set_count")]
    public int LimitSetCount { get; set; }

    [JsonPropertyName("Limit_set_leg_count")]
    public int LimitSetLegCount { get; set; }

    [JsonPropertyName("startScore")]
    public int StartScore { get; set; }

    [JsonPropertyName("limit_rounds")]
    public int LimitRounds { get; set; }

    [JsonPropertyName("rounds")]
    public int Rounds { get; set; }

    [JsonPropertyName("changeFirst")]
    public int ChangeFirst { get; set; }

    [JsonPropertyName("exitResult")]
    public int ExitResult { get; set; }

    [JsonPropertyName("autoNext")]
    public int AutoNext { get; set; }

    [JsonPropertyName("setOrder")]
    public int SetOrder { get; set; }

    [JsonPropertyName("point")]
    public int Point { get; set; }

    [JsonPropertyName("point_w")]
    public int PointWin { get; set; }

    [JsonPropertyName("point_d")]
    public int PointDraw { get; set; }

    [JsonPropertyName("point_l")]
    public int PointLoss { get; set; }

    [JsonPropertyName("exclude_from_stats")]
    public int ExcludeFromStats { get; set; }

    [JsonPropertyName("game_setting")]
    public GameSettings[] GameSettings { get; set; } = null!;
}
