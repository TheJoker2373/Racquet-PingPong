using UnityEngine;
using System.Runtime.InteropServices;
public class LocalizationHandler : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string GetLanguageExtern();
    public static LocalizationHandler Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    public string GetLanguage()
    {
        return GetLanguageExtern();
    }
}