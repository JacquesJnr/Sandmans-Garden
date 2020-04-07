using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private TMPro.TextMeshPro timeText;
    private float day;
    private const float RealTime = 60f;

    private void Awake()
    {
        timeText = GetComponent<TMPro.TextMeshPro>();
        Time.timeScale = 0.5f;
    }

    void Update()
    {
        day += Time.deltaTime / RealTime;
        var timeNow = System.DateTime.Now;

        float dayNormalized = day % 1f;
        float hoursPerDay = 24f;
        float minutesPerHour = 60f;


        timeText.text = "<#ffffff>" + timeNow.Hour.ToString("d2") + ":" + timeNow.Minute.ToString("d2") + "</color> \n";
        //string minutesString = Mathf.Floor(((dayNormalized * hoursPerDay) % 1f) * minutesPerHour).ToString("00");

        //timeText.text = hoursString + ":" + minutesString;
    }
}
