using System.Text.Json;
using Mcgiany.NakkaClient.Entities;

namespace Mcgiany.NakkaClient.Extensions;
public static class NakkaTournamentExtensions
{
    internal static List<Dictionary<string, Dictionary<string, GameScore>>> GetTournamentResults(this InternalNakkaTournament tournament)
    {
        return GetResults(tournament.TournamentResults);
    }

    internal static List<Dictionary<string, Dictionary<string, GameScore>>> GetRoundRobinResults(this InternalNakkaTournament tournament)
    {
        return GetResults(tournament.RoundRobinResults);
    }

    private static List<Dictionary<string, Dictionary<string, GameScore>>> GetResults(object results)
    {
        try
        {
            var result = new List<Dictionary<string, Dictionary<string, GameScore>>>();
            var deserialized = ((JsonElement)results).Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, GameScore>>>>();
            foreach (var item in deserialized)
            {
                result.Add(item.Value);
            }
            return result;
        }
        catch
        { }
        return ((JsonElement)results).Deserialize<List<Dictionary<string, Dictionary<string, GameScore>>>>();
    }

    internal static List<Dictionary<string, int>> GetRanks(this InternalNakkaTournament tournament)
    {
        if (tournament.RobinRoundRank is null)
        {
            return null;
        }
        try
        {
            List<Dictionary<string, int>> result = new List<Dictionary<string, int>>();
            foreach (KeyValuePair<string, Dictionary<string, int>> item in ((JsonElement)tournament.RobinRoundRank).Deserialize<Dictionary<string, Dictionary<string, int>>>())
            {
                result.Add(item.Value);
            }
            return result;
        }
        catch
        {
        }
        return ((JsonElement)tournament.RobinRoundRank).Deserialize<List<Dictionary<string, int>>>();
    }
}
