using System;

namespace Mcgiany.NakkaClient.Entities;

internal class GroupMatch
{
    public string Player { get; set; } = null!;

    public string Opponent { get; set; } = null!;

    public decimal Average { get; set; }

    public int PlayerScore { get; set; }

    public int OpponentScore { get; set; }
}
