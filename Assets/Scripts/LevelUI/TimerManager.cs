using TMPro;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public static TimerManager Instance { get; private set; }

    [SerializeField] 
    private TextMeshProUGUI timerText;

    private int minutes;
    private float seconds;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        seconds += Time.deltaTime;

        if (seconds >= 60)
        {
            seconds = 0;
            minutes++;
        }

        timerText.text = GetTimerString();
    }

    public string GetTimerString()
    {
        string minuteText = "";
        string secondsText = "";

        if (minutes < 10)
        {
            minuteText = "0" + minutes;
        }
        else
        {
            minuteText = minutes.ToString();
        }

        if (seconds < 10)
        {
            secondsText = "0" + (int)seconds;
        }
        else
        {
            secondsText = ((int)seconds).ToString();
        }

        string result = minuteText + ":" + secondsText;

        return result;
    }
}
