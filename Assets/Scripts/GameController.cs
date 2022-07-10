using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text canvasTimerText;

    [SerializeField]
    private float totalTime;

    [SerializeField]
    private GameObject player;
    private float initialTime;
    private float canvasTime;

    void Start()
    {
        initialTime = Time.time;
    }


    private void FixedUpdate()
    {
        Timer();
        if (canvasTime < totalTime / 3)
            canvasTimerText.color = new Color(1, 0, 0);
        else if (canvasTime < totalTime * 2/3)
            canvasTimerText.color = new Color(1, 1, 0);

        if ((canvasTime < 0)||player.GetComponent<PlayerController>().hp < 1 )
        {
            Debug.Log("GameOver");
        }


    }

    private void Timer()
    {
        canvasTime = totalTime - Time.time - initialTime;
        int minutes = (int) canvasTime / 60;
        int seconds = (int) canvasTime % 60;
        canvasTimerText.text = $"{minutes}:{seconds}";
    }
}
