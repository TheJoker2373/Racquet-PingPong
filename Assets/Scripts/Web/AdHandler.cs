using System.Runtime.InteropServices;
public static class AdHandler
{
    [DllImport("__Internal")]
    public static extern void ShowAd();
    [DllImport("__Internal")]
    public static extern void ReviveAd();
}