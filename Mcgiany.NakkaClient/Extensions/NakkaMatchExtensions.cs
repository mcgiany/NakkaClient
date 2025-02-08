using Mcgiany.NakkaClient.Entities;

namespace Mcgiany.NakkaClient.Extensions;

public static class NakkaMatchExtensions
{
    public static (int Player1Attempts, int Player2Attempts) MatchDoubleAttempts(this NakkaMatch match)
    {
        var playersAttempts = new int[2];
        foreach (var leg in match.LegData)
        {
            for (int playerNumber = 0; playerNumber < leg.PlayerData.Length; playerNumber++)
            {
                var playerData = leg.PlayerData[playerNumber];
                var playerAttempts = 0;
                for (int visitNumber = 1; visitNumber < playerData.Length; visitNumber++)
                {
                    var current = playerData[visitNumber];
                    var previous = playerData[visitNumber - 1];
                    var finish = current.Score > 0 ? 0 : current.Score * -1;
                    playerAttempts += GetCheckoutCount(current.Left, previous.Left, finish);
                }
                playersAttempts[playerNumber] += playerAttempts;
            }
        }
        return (playersAttempts[0], playersAttempts[1]);
    }

    private static int GetCheckoutCount(int left, int old_left, int finish)
    {
        if (left == 0)
        {
            if (old_left > 50)
            {
                if (old_left < 99 || old_left == 100 || old_left == 101 || old_left == 104 || old_left == 107 || old_left == 110)
                {
                    return (finish == 1) ? 1 : finish - 1;
                }
                else
                {
                    return 1;
                }
            }
            else if (old_left == 50 || old_left <= 40 && old_left % 2 == 0)
            {
                return finish;
            }
            else
            {
                return (finish == 1) ? 1 : finish - 1;
            }
        }
        if (left == old_left || left < 50)
        {
            if (old_left > 50)
            {
                if (old_left < 99 || old_left == 100 || old_left == 101 || old_left == 104 || old_left == 107 || old_left == 110)
                {
                    return (left == old_left || left <= 40) ? 2 : 1;
                }
                else if (old_left <= 158 || old_left == 160 || old_left == 161 || old_left == 164 || old_left == 167 || old_left == 170)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (old_left == 50 || old_left <= 40 && old_left % 2 == 0)
            {
                return (left == old_left || left <= 40) ? 3 : 1;
            }
            else
            {
                return (left == old_left || left <= 40) ? 2 : 0;
            }
        }
        return 0;
    }
}
