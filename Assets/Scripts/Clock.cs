using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private TMPro.TextMeshPro timeText;

    private void Awake()
    {
        timeText = GetComponent<TMPro.TextMeshPro>();
        Time.timeScale = 0.5f;
    }

    void Update()
    {
        var timeNow = System.DateTime.Now;

        timeText.text = "<#ffffff>" + timeNow.Hour.ToString("d2") + ":" + timeNow.Minute.ToString("d2") + "</color> \n";
    }
}
