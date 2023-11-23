using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class TimeText1 : MonoBehaviour
{
    float timer = 0;
    public TextMeshProUGUI TimerText;
    private void Update()
    {
        timer += UnityEngine.Time.deltaTime;
        TimerText.text = timer.ToString("F2") + "s";
    }
}
