using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    [SerializeField] private float _maxVelocity = 15f;
    [SerializeField] private float _minImpulse = 0.4f;
    [SerializeField] private float _impulseDivider = 1500f;
    private Rigidbody2D _rigidBody;
    private AudioSource _audio;
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
    }
    private void OnValidate()
    {
        if (_maxVelocity < 0)
            _maxVelocity = 0;
        if (_minImpulse < 0)
            _minImpulse = 0;
        if (_impulseDivider < 0)
            _impulseDivider = 0;
    }
    private void Start()
    {
        _rigidBody.Sleep();
    }
    private void FixedUpdate()
    {
        _rigidBody.velocity = Vector2.ClampMagnitude(_rigidBody.velocity, _maxVelocity); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Racquet>())
        {
            float impulse = collision.GetContact(0).normalImpulse / _impulseDivider;
            if (impulse < _minImpulse)
                return;
            CountHandler.Instance.IncreseCount();
            _audio.pitch = Random.Range(0.8f, 1.2f);
            _audio.volume = impulse;
            _audio.Play();
        }
    }
}