using System.Runtime.InteropServices;
public static class LocalizationHandler
{
    [DllImport("__Internal")]
    public static extern string GetLanguage();
}