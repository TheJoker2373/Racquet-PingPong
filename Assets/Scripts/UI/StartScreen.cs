using UnityEngine;
public class StartScreen : MonoBehaviour
{
    [SerializeField] private FadeAnimation _startScreen;
    [SerializeField] private FadeAnimation _countHandler;
    private void Start()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        _startScreen.FadeOut();
        _countHandler.FadeIn();
        Time.timeScale = 1f;
    }
}