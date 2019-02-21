using UnityEngine;

public class UniAndroidVibration
{
    private const string PackageClassPath = "net.sanukin.vibration.UniVibration";
    
    public static void Vibrate(int milliseconds)
    {
#if !UNITY_EDITOR && UNITY_ANDROID
        var javaClass = new AndroidJavaClass(PackageClassPath);
        javaClass.CallStatic("vibrate", milliseconds);
#endif
    }
}
