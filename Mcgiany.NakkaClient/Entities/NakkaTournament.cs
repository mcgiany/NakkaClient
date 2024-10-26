using System.Text.Json.Serialization;
using Mcgiany.NakkaClient.Enums;

namespace Mcgiany.NakkaClient.Entities;

public class NakkaTournament
{
    [JsonPropertyName("tdid")]
    public string TournamentId { get; set; } = null!;

    [JsonPropertyName("createTime")]
    public long CreateTime { get; set; }

    [JsonPropertyName("updateTime")]
    public long UpdateTime { get; set; }

    [JsonPropertyName("status")]
    public NakkaStatus Status { get; set; }

    [JsonPropertyName("ad")]
    public int Ad { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("t_date")]
    public long TournamentDate { get; set; }

    [JsonPropertyName("s_date")]
    public long StartDate { get; set; }

    [JsonPropertyName("details")]
    public string Details { get; set; } = null!;

    [JsonPropertyName("image")]
    public string Image { get; set; } = null!;

    [JsonPropertyName("color")]
    public string Color { get; set; } = null!;

    [JsonPropertyName("chat")]
    public int Chat { get; set; }

    [JsonPropertyName("show_avg")]
    public int ShowAvg { get; set; }

    [JsonPropertyName("auto_complete")]
    public int AutoComplete { get; set; }

    [JsonPropertyName("dynamic_avg")]
    public int DynamicAvg { get; set; }

    [JsonPropertyName("game_type")]
    public int GameType { get; set; }

    [JsonPropertyName("individual_pass")]
    public int IndividualPass { get; set; }

    [JsonPropertyName("hide_sns")]
    public int HideSns { get; set; }

    [JsonPropertyName("common_join")]
    public int CommonJoin { get; set; }

    [JsonPropertyName("show_entry_no")]
    public int ShowEntryNumber { get; set; }

    [JsonPropertyName("team_games")]
    public int TeamGames { get; set; }

    [JsonPropertyName("name_sep")]
    public string NameSep { get; set; } = null!;

    [JsonPropertyName("private")]
    public int Private { get; set; }

    [JsonPropertyName("lgid")]
    public string LeagueId { get; set; } = null!;

    [JsonPropertyName("league")]
    public int League { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; } = null!;

    [JsonPropertyName("rr_setting")]
    public RoundRobinSettings RoundRobinSettings { get; set; } = null!;

    [JsonPropertyName("rr_table")]
    public string[][] RoundRobinTable { get; set; } = null!;

    [JsonPropertyName("rr_result")]
    public object RoundRobinResults { get; set; } = null!;

    [JsonPropertyName("t_setting")]
    public TournamentSettings TournamentSettings { get; set; } = null!;

    [JsonPropertyName("t_title")]
    public string[] TournamentTitle { get; set; } = null!;

    [JsonPropertyName("t_table")]
    public object[] TournamentTable { get; set; } = null!;

    [JsonPropertyName("t_result")]
    public object TournamentResults { get; set; } = null!;

    [JsonPropertyName("entry_list")]
    public Player[] EntryList { get; set; } = null!;

    [JsonPropertyName("rr_rank")]
    public object RobinRoundRank { get; set; } = null!;
}
