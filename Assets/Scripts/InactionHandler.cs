using UnityEngine;
using TMPro;
using System.Collections;
public class InactionHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textHolder;
    [SerializeField] private float _minMagnitude = 0.5f;
    private Rigidbody2D _ball;
    private EndScreen _endScreen;
    private Coroutine _coroutine;
    private bool _isCounting;
    private void Awake()
    {
        _ball = FindObjectOfType<Ball>().GetComponent<Rigidbody2D>();
        _endScreen = FindObjectOfType<EndScreen>();
    }
    private void OnValidate()
    {
        if (_minMagnitude < 0)
            _minMagnitude = 0;
    }
    private void Update()
    {
        if (_ball.velocity.magnitude < _minMagnitude && _ball.IsSleeping() == false)
            StartCounting();
        else
            StopCounting();
    }
    public void StartCounting()
    {
        if (_isCounting == true)
            return;
        _isCounting = true;
        _coroutine = StartCoroutine(Count());
    }
    public void StopCounting()
    {
        if (_isCounting == false)
            return;
        StopCoroutine(_coroutine);
        _textHolder.text = string.Empty;
        _isCounting = false;
    }
    private IEnumerator Count()
    {
        yield return new WaitForSeconds(1f);
        _textHolder.text = "3";
        yield return new WaitForSeconds(1f);
        _textHolder.text = "2";
        yield return new WaitForSeconds(1f);
        _textHolder.text = "1";
        yield return new WaitForSeconds(1f);
        _textHolder.text = "0";
        yield return new WaitForSeconds(1f);
        _textHolder.text = string.Empty;
        _endScreen.OpenScreen();
    }
}