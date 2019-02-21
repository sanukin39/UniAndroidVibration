package net.sanukin.vibration;

import android.app.Activity;
import android.content.Context;
import android.os.Vibrator;
import com.unity3d.player.UnityPlayer;


public class UniVibration {
    public static void vibrate(int milliseconds)
    {
        Activity activity = UnityPlayer.currentActivity;
        Vibrator vibrator = (Vibrator)activity.getSystemService(Context.VIBRATOR_SERVICE);
        vibrator.vibrate(milliseconds);
    }
}
