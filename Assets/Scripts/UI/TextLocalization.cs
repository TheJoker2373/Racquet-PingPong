using UnityEngine;
using TMPro;
[RequireComponent(typeof(TextMeshProUGUI))]
public class TextLocalization : MonoBehaviour
{
    [SerializeField] private string _ru;
    [SerializeField] private string _en;
    private TextMeshProUGUI _textHolder;
    private void Awake()
    {
        _textHolder = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        if (LocalizationHandler.GetLanguage() == "en")
            _textHolder.text = _en;
        else
            _textHolder.text = _ru;
    }
}