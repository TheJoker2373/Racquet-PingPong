using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class DeadZone : MonoBehaviour
{
    private EndScreen _endScreen;
    private void Awake()
    {
        _endScreen = FindObjectOfType<EndScreen>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
            _endScreen.OpenScreen();
    }
}