using UnityEngine;
using System.Runtime.InteropServices;
public class AdHandler : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdExtern();
    [DllImport("__Internal")]
    private static extern void ReviveExtern();
    [SerializeField] private FadeAnimation _reviveButton;
    public static AdHandler Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    public void ShowReviveAd()
    {
        _reviveButton.FadeOut();
        ReviveExtern();
    }
    public void ShowAd()
    {
        ShowAdExtern();
    }
}