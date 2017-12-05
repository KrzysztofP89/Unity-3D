using UnityEngine;
using UnityEngine.UI;

public class DigitalCountdown : MonoBehaviour
{
    private Text textClock;
    private float countdownTimerDelay;
    private float countdownTimerStartTime;

    [SerializeField]
    private int time = 30;

    void Start()
    {
        textClock = GetComponent<Text>(); 
        CountdownTimerReset(time);
    }

    void Update()
    {
        string timerMessage = "countdown has finished";
        int timeLeft = (int)CountdownTimerSecondsRemaining();

        if (timeLeft > 0)
            timerMessage = "Countdown seconds remaining = " + LeadingZero(timeLeft);

        textClock.text = timerMessage;
    }

    private void CountdownTimerReset(float delayInSeconds)
    {
        countdownTimerDelay = delayInSeconds;
        countdownTimerStartTime = Time.time;
    }

    private float CountdownTimerSecondsRemaining()
    {
        float elapsedSeconds = Time.time - countdownTimerStartTime;
        float timeLeft = countdownTimerDelay - elapsedSeconds;
        return timeLeft;
    }

    private string LeadingZero(int n)
    {
        return n.ToString().PadLeft(1, '0');
    }
}
