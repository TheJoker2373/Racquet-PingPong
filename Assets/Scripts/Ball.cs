using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    [SerializeField] private float _maxVelocity;
    private Rigidbody2D _rigidBody;
    private AudioSource _audio;
    private CountHandler _counter;
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
        _counter = FindObjectOfType<CountHandler>();
    }
    private void OnValidate()
    {
        if (_maxVelocity < 0)
            _maxVelocity = 0;
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
            float impulse = collision.GetContact(0).normalImpulse / 1500f;
            if (impulse < 0.4f)
                return;
            _counter.IncreseCount();
            _audio.pitch = Random.Range(0.8f, 1.2f);
            _audio.volume = impulse;
            _audio.Play();
        }
    }
}