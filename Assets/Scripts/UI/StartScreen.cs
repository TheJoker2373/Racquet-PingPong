using UnityEngine;
public class StartScreen : MonoBehaviour
{
    [SerializeField] private FadeAnimation _startScreen;
    [SerializeField] private FadeAnimation _countHandler;
    public static StartScreen Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
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