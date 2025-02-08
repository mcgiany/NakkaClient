namespace Mcgiany.NakkaClient.Entities;

public class RoundRobinGroup
{
    /// <summary>
    /// Round robin group number.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Players in round robin group.
    /// </summary>
    public List<RoundRobinGroupPlayer> Players { get; set; } = new();
}
