using System.Runtime.InteropServices;
public static class LeaderboardHandler
{
    [DllImport("__Internal")]
    public static extern void SetLeaderboard(int score);
}