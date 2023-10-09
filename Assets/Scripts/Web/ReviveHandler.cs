using UnityEngine;
public class ReviveHandler : MonoBehaviour
{
    private Racquet _racquet;
    private Ball _ball;
    private Vector2 _racquetStartPos;
    private Vector2 _ballStartPos;
    private void Awake()
    {
        _racquet = FindObjectOfType<Racquet>();
        _ball = FindObjectOfType<Ball>();
    }
    private void Start()
    {
        _racquetStartPos = _racquet.transform.position;
        _ballStartPos = _ball.transform.position;
    }
    public void Revive()
    {
        _racquet.transform.position = _racquetStartPos;
        _ball.transform.position = _ballStartPos;
        _ball.GetComponent<Rigidbody2D>().Sleep();
        EndScreen.Instance.CloseScreen();
    }
}