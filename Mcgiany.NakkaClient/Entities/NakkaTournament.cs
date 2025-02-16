using Mcgiany.NakkaClient.Enums;
using Mcgiany.NakkaClient.Extensions;

namespace Mcgiany.NakkaClient.Entities;

public class NakkaTournament
{
    private InternalNakkaTournament _internalTournament;

    internal NakkaTournament(InternalNakkaTournament internalTournament)
    {
        _internalTournament = internalTournament;
    }

    public string TournamentId => _internalTournament.TournamentId;

    public long CreateTime => _internalTournament.CreateTime;

    public long UpdateTime => _internalTournament.UpdateTime;

    public NakkaStatus Status => _internalTournament.Status;

    public int Ad => _internalTournament.Ad;

    public string Title => _internalTournament.Title;

    public long TournamentDate => _internalTournament.TournamentDate;

    public long StartDate => _internalTournament.StartDate;

    public string Details => _internalTournament.Details;

    public string Image => _internalTournament.Image;

    public string Color => _internalTournament.Color;

    public int Chat => _internalTournament.Chat;

    public int ShowAvg => _internalTournament.ShowAvg;

    public int AutoComplete => _internalTournament.AutoComplete;

    public int DynamicAvg => _internalTournament.DynamicAvg;

    public int GameType => _internalTournament.GameType;

    public int IndividualPass => _internalTournament.IndividualPass;

    public int HideSns => _internalTournament.HideSns;

    public int CommonJoin => _internalTournament.CommonJoin;

    public int ShowEntryNumber => _internalTournament.ShowEntryNumber;

    public int TeamGames => _internalTournament.TeamGames;

    public string NameSep => _internalTournament.NameSep;

    public int Private => _internalTournament.Private;

    public string LeagueId => _internalTournament.LeagueId;

    public int League => _internalTournament.League;

    public string Kind => _internalTournament.Kind;

    public RoundRobinSettings RoundRobinSettings => _internalTournament.RoundRobinSettings;

    public string[][] RoundRobinTable => _internalTournament.RoundRobinTable;

    public List<Dictionary<string, Dictionary<string, GameScore>>> RoundRobinResults => _internalTournament.GetRoundRobinResults();

    public TournamentSettings TournamentSettings => _internalTournament.TournamentSettings;

    public string[] TournamentTitle => _internalTournament.TournamentTitle;

    public object[] TournamentTable => _internalTournament.TournamentTable;

    public List<Dictionary<string, Dictionary<string, GameScore>>> TournamentResults => _internalTournament.GetTournamentResults();

    public NakkaPlayer[] EntryList => _internalTournament.EntryList;

    public List<Dictionary<string, int>> RobinRoundRank => _internalTournament.GetRanks();

    public Dictionary<string, Badge> Badges => _internalTournament.Badges;
}
