using UnityEngine;

public class UniAndroidVibration
{
    private const string PackageClassPath = "net.sanukin.vibration.UniVibration";
#if !UNITY_EDITOR && UNITY_ANDROID
    private static AndroidJavaClass _javaClass;
#endif

    public static void Vibrate(int milliseconds)
    {
#if !UNITY_EDITOR && UNITY_ANDROID
        if (_javaClass == null)
        {
            _javaClass = new AndroidJavaClass(PackageClassPath);
        }
        _javaClass.CallStatic("vibrate", milliseconds);
#endif
    }
}
