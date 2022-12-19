using System.Text.Json.Serialization;

namespace Mcgiany.NakkaClient.Entities;

public class Match
{
    [JsonPropertyName("tdid")]
    public string TournamentId { get; set; } = null!;

    [JsonPropertyName("lgid")]
    public string LeagueId { get; set; } = null!;

    [JsonPropertyName("tmid")]
    public string MatchID { get; set; } = null!;

    [JsonPropertyName("ttype")]
    public string Ttype { get; set; } = null!;

    [JsonPropertyName("round")]
    public string Round { get; set; } = null!;

    [JsonPropertyName("t_no")]
    public int TNo { get; set; }

    [JsonPropertyName("mid")]
    public string Mid { get; set; } = null!;

    [JsonPropertyName("scid")]
    public string Scid { get; set; } = null!;

    [JsonPropertyName("scMode")]
    public int ScMode { get; set; }

    [JsonPropertyName("shid")]
    public string Schid { get; set; } = null!;

    [JsonPropertyName("exitResult")]
    public int ExitResult { get; set; }

    [JsonPropertyName("autoNext")]
    public int AutoNext { get; set; }

    [JsonPropertyName("startTime")]
    public long StartTime { get; set; }

    [JsonPropertyName("updateTime")]
    public long UpdateTime { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("orgTitle")]
    public string OrgTitle { get; set; } = null!;

    [JsonPropertyName("startScore")]
    public int StartScore { get; set; }

    [JsonPropertyName("roundLimit")]
    public int RoundLimit { get; set; }

    [JsonPropertyName("maxRound")]
    public int MaxRound { get; set; }

    [JsonPropertyName("currentInput")]
    public string CurrentInput { get; set; } = null!;

    [JsonPropertyName("currentSet")]
    public int CurrentSet { get; set; }

    [JsonPropertyName("currentLeg")]
    public int CurrentLeg { get; set; }

    [JsonPropertyName("limitSet")]
    public int LimitSet { get; set; }

    [JsonPropertyName("limitLeg")]
    public int LimitLeg { get; set; }

    [JsonPropertyName("drawMode")]
    public int DrawMode { get; set; }

    [JsonPropertyName("endMatch")]
    public int EndMatch { get; set; }

    [JsonPropertyName("viewMode")]
    public int ViewMode { get; set; }

    [JsonPropertyName("relayMode")]
    public int RelayMode { get; set; }

    [JsonPropertyName("tournamentMode")]
    public int TournamentMode { get; set; }

    [JsonPropertyName("private")]
    public int Private { get; set; }

    [JsonPropertyName("delete")]
    public int Delete { get; set; }

    [JsonPropertyName("legData")]
    public MatchLegData[] LegData { get; set; } = null!;

    [JsonPropertyName("statsData")]
    public MatchStatsData[] StatsData { get; set; } = null!;
}
