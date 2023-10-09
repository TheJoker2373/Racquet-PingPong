using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
            EndScreen.Instance.OpenScreen();
    }
}