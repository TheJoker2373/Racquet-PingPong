using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class TextLocalization : MonoBehaviour
{
    [SerializeField] private string _ru;
    [SerializeField] private string _en;
    private Text _textHolder;
    private void Awake()
    {
        _textHolder = GetComponent<Text>();
    }
    private void Start()
    {
        if (LocalizationHandler.Instance.GetLanguage() == "en")
            _textHolder.text = _en;
        else
            _textHolder.text = _ru;
    }
}