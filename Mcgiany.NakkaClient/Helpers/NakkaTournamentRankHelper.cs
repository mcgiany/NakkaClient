using System.Text.Json;

namespace Mcgiany.NakkaClient.Helpers;

public static class NakkaTournamentRankHelper
{
    public static List<Dictionary<string, int>> GetRanks(object ranks)
    {
        if (ranks is null)
        {
            return null;
        }
        try
        {
            List<Dictionary<string, int>> result = new List<Dictionary<string, int>>();
            foreach (KeyValuePair<string, Dictionary<string, int>> item in ((JsonElement)ranks).Deserialize<Dictionary<string, Dictionary<string, int>>>())
            {
                result.Add(item.Value);
            }
            return result;
        }
        catch
        {
        }
        return ((JsonElement)ranks).Deserialize<List<Dictionary<string, int>>>();
    }
}