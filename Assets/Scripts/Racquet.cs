using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Racquet : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private Vector2 _startPosition;
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    public void SaveStartPos()
    {
        _startPosition = transform.position;
    }
    public void Move(Vector2 position)
    {
        _rigidBody.MovePosition(_startPosition + position);
    }
}
