using System;

namespace Mcgiany.NakkaClient.Entities;

public class RoundRobinGroupPlayer
{
    public string Player { get; set; } = null!;

    public int Points { get; set; }

    public int WinLegs { get; set; }

    public int LostLegs { get; set; }

    public int LegDiff => WinLegs - LostLegs;

    public int PlayedLegs => WinLegs + LostLegs;

    public decimal BestAvg { get; set; }

    public int Rank { get; set; }

    public int ForcedRank { get; set; }

    public int Wins { get;set; }
}
