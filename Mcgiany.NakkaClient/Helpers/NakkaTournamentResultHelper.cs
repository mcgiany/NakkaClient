using System.Text.Json;
using Mcgiany.NakkaClient.Entities;

namespace Mcgiany.NakkaClient.Helpers;

public static class NakkaTournamentResultHelper
{
    public static List<Dictionary<string, Dictionary<string, GameScore>>> GetResult(object result)
    {
        try
        {
            List<Dictionary<string, Dictionary<string, GameScore>>> list = new List<Dictionary<string, Dictionary<string, GameScore>>>();
            foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, GameScore>>> item in ((JsonElement)result).Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, GameScore>>>>())
            {
                list.Add(item.Value);
            }
            return list;
        }
        catch
        {
        }
        return ((JsonElement)result).Deserialize<List<Dictionary<string, Dictionary<string, GameScore>>>>();
    }
}
