using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TimeToEndHandler : MonoBehaviour
{
    [SerializeField] private Text _textHolder;
    private Rigidbody2D _ball;
    private Coroutine _coroutine;
    private bool _isCounting;
    private void Awake()
    {
        _ball = FindObjectOfType<Ball>().GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (_ball.velocity.magnitude < 0.5f)
            StartCounting();
        else
            StopCounting();
    }
    public void StartCounting()
    {
        if (_isCounting == false)
        {
            _isCounting = true;
            _coroutine = StartCoroutine(Count());
        }
    }
    public void StopCounting()
    {
        if (_isCounting == true)
        {
            StopCoroutine(_coroutine);
            _textHolder.text = string.Empty;
            _isCounting = false;
        }
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
        EndScreen.Instance.OpenScreen();
    }
}