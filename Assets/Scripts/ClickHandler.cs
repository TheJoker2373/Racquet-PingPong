using UnityEngine;
public class ClickHandler : MonoBehaviour
{
    [SerializeField] private Collider2D _collider;
    private Vector2 _startPos;
    private bool _isGrabbing;
    private Racquet _raquet;
    private void Awake()
    {
        _raquet = FindObjectOfType<Racquet>();
    }
    private void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            _isGrabbing = false;
            RaycastHit2D[] hits = Physics2D.RaycastAll(mousePosition, Vector2.zero);
            foreach (var hit in hits)
            {
                if (hit.collider == _collider)
                {
                    _isGrabbing = true;
                    _startPos = mousePosition;
                    _raquet.SaveStartPos();
                    break;
                }
            }
        }
        if (Input.GetMouseButton(0) && _isGrabbing)
        {
            Vector2 offset = mousePosition - _startPos;
            _raquet.Move(offset);
        }
    }
}