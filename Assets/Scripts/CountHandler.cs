using UnityEngine;
using UnityEngine.UI;
public class CountHandler : MonoBehaviour
{
    [SerializeField] private Text _textHolder;
    public static CountHandler Instance {  get; private set; }
    public int Count { get; private set; }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    private void Start()
    {
        Count = 0;
        _textHolder.text = Count.ToString();
    }
    public void IncreseCount()
    {
        Count++;
        _textHolder.text = Count.ToString();
    }
}