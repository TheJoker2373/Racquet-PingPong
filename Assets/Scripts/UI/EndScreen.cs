using UnityEngine;
public class EndScreen : MonoBehaviour
{
    [SerializeField] private FadeAnimation _endScreen;
    [SerializeField] private FadeAnimation _countHolder;
    public void OpenScreen()
    {
        Time.timeScale = 0f;
        _endScreen.FadeIn();
        _countHolder.FadeOut();
        AdHandler.FullscreenAd();
    }
    public void CloseScreen()
    {
        Time.timeScale = 1f;
        _endScreen.FadeOut();
        _countHolder.FadeIn();
    }
    public void Restart()
    {
        ReloadHandler.Reload();
        LeaderboardHandler.SetLeaderboard(CountHandler.Instance.Count);
    }
}