using UnityEngine;
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CanvasGroup))]
public class FadeAnimation : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnValidate()
    {
        if (_speed < 0)
            _speed = 0;
    }
    public void FadeIn()
    {
        _animator.speed = _speed;
        _animator.SetBool("Fade", true);
    }
    public void FadeOut()
    {
        _animator.speed = _speed;
        _animator.SetBool("Fade", false);
    }
}