using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private TMPro.TextMeshPro timeText;
    private const float realSeconds = 80f;
    private float day;

    private void Awake()
    {
        Time.timeScale = 1;
        timeText = GetComponent<TMPro.TextMeshPro>();
    }

    void Update()
    {
        var timeNow = System.DateTime.Now;
        day += Time.deltaTime / realSeconds;
        float dayNormalised = day % 1f;
        float minutesPerHour = 60f;
        float hoursPerDay = 24f;
        string minuteString, hourString;

        minuteString = Mathf.Floor(((dayNormalised * hoursPerDay) % 1f) * minutesPerHour).ToString("00");
        hourString = Mathf.Floor(dayNormalised * hoursPerDay).ToString("00");

        timeText.text = "<#ffffff>" + timeNow.Hour.ToString("d2") + ":" + timeNow.Minute.ToString("d2") + "</color> \n";
        //timeText.text = hourString + ":" + minuteString;

        if (Input.GetKey(KeyCode.Space))
        {
            timeText.text = hourString + ":" + minuteString;
        }
    }
}
