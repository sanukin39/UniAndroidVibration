using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    [SerializeField] private InputField _vibrateMillisecondsInputField;
    [SerializeField] private Button _vibrateButton;

    void Awake()
    {
        _vibrateButton.onClick.AddListener(Vibrate);
    }

    void Vibrate()
    {
        var milliseconds = int.Parse(_vibrateMillisecondsInputField.text);
        UniAndroidVibration.Vibrate(milliseconds);
    }
}
