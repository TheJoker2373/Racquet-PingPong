using UnityEngine;
public class ReviveHandler : MonoBehaviour
{
    private Racquet _racquet;
    private Ball _ball;
    private EndScreen _endScreen;
    private Vector2 _racquetStartPos;
    private Vector2 _ballStartPos;
    private void Awake()
    {
        _racquet = FindObjectOfType<Racquet>();
        _ball = FindObjectOfType<Ball>();
        _endScreen = FindObjectOfType<EndScreen>();
    }
    private void Start()
    {
        _racquetStartPos = _racquet.transform.position;
        _ballStartPos = _ball.transform.position;
    }
    public void ShowAd()
    {
        AdHandler.ReviveAd();
    }
    public void Revive()
    {
        _racquet.transform.position = _racquetStartPos;
        _ball.transform.position = _ballStartPos;
        _ball.GetComponent<Rigidbody2D>().Sleep();
        _endScreen.CloseScreen();
    }
}