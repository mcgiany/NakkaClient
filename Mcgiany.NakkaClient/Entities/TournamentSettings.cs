using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class TournamentSettings
{
    [JsonPropertyName("tournament")]
    public int Tournament { get; set; }

    [JsonPropertyName("t_player_count")]
    public int PlayterCount { get; set; }

    [JsonPropertyName("t3")]
    public int T3 { get; set; }

    [JsonPropertyName("auto_continue")]
    public int AutoContinue { get; set; }

    [JsonPropertyName("disp_no")]
    public int DispNo { get; set; }

    [JsonPropertyName("sequential")]
    public int Sequential { get; set; }

    [JsonPropertyName("Show_no_all")]
    public int ShowNoAll { get; set; }

    [JsonPropertyName("show_badge")]
    public int ShowBadge { get; set; }

    [JsonPropertyName("exclude_from_stats")]
    public int Exclude_from_stats { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("limit_leg_count")]
    public int LimitLegCount { get; set; }

    [JsonPropertyName("limit_set_count")]
    public int LimitSetCount { get; set; }

    [JsonPropertyName("limit_set_leg_count")]
    public int LimitSetLegCount { get; set; }

    [JsonPropertyName("changeFirst")]
    public int ChangeFirst { get; set; }

    [JsonPropertyName("ExitResult")]
    public int ExitResult { get; set; }

    [JsonPropertyName("autoNext")]
    public int AutoNext { get; set; }

    [JsonPropertyName("setOrder")]
    public int SetOrder { get; set; }

    [JsonPropertyName("startScore")]
    public int StartScore { get; set; }

    [JsonPropertyName("limit_rounds")]
    public int Limit_rounds { get; set; }

    [JsonPropertyName("rounds")]
    public int Rounds { get; set; }

    [JsonPropertyName("game_setting")]
    public GameSettings[] GameSettings { get; set; } = null!;
}
