using UnityEngine;
using System.Runtime.InteropServices;
public class LeaderboardHandler : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void SetLeaderBoardExtern(int score);
    public void SetLeaderBoard()
    {
        SetLeaderBoardExtern(CountHandler.Instance.Count);
    }
}