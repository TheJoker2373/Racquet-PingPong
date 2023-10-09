using UnityEngine;
public class EndScreen : MonoBehaviour
{
    [SerializeField] private FadeAnimation _endScreen;
    [SerializeField] private FadeAnimation _counterHolder;
    public static EndScreen Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    public void OpenScreen()
    {
        Time.timeScale = 0f;
        _endScreen.FadeIn();
        _counterHolder.FadeOut();
        AdHandler.Instance.ShowAd();
    }
    public void CloseScreen()
    {
        Time.timeScale = 1f;
        _endScreen.FadeOut();
        _counterHolder.FadeIn();
    }
}