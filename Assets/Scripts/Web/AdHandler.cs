using System.Runtime.InteropServices;
public static class AdHandler
{
    [DllImport("__Internal")]
    public static extern void FullscreenAd();
    [DllImport("__Internal")]
    public static extern void ReviveAd();
}