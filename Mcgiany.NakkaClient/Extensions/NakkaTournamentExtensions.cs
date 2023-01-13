using System.Text.Json;
using Mcgiany.NakkaClient.Entities;

namespace Mcgiany.NakkaClient.Extensions;
public static class NakkaTournamentExtensions
{
    public static List<Dictionary<string, Dictionary<string, GameScore>>> GetTournamentResults(this NakkaTournament tournament)
    {
        try
        {
            var result = new List<Dictionary<string, Dictionary<string, GameScore>>>();
            var deserialized = ((JsonElement)tournament.TournamentResults).Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, GameScore>>>>();
            foreach (var item in deserialized)
            {
                result.Add(item.Value);
            }
            return result;
        }
        catch
        { }
        return ((JsonElement)tournament.TournamentResults).Deserialize<List<Dictionary<string, Dictionary<string, GameScore>>>>();
    }
}
