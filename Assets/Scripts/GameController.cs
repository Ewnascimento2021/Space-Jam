using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text canvasTimerText;

    [SerializeField]
    private float totalTime;
    [SerializeField]
    private GameObject door;

    [SerializeField]
    private GameObject player;
    private float initialTime;
    private float canvasTime;

    public bool isGreenButtonPressed;


    void Start()
    {


        initialTime = Time.time;

    }
    private void Update()
    {

        if (isGreenButtonPressed)
        {
            door.GetComponent<SpriteRenderer>().color = new Color(0, 0.75f, 0.35f);
            door.GetComponent<BoxCollider2D>().isTrigger = true;
        }


    }
    private void FixedUpdate()
    {
        Timer();
        if (canvasTime < totalTime / 3)
            canvasTimerText.outlineColor = new Color(1, 0, 0);
        else if (canvasTime < totalTime * 2 / 3)
            canvasTimerText.outlineColor = new Color(1, 1, 0);

        if ((canvasTime < 0) || player.GetComponent<PlayerController>().hp < 1)
        {
            SceneManager.LoadScene("GameOverScreen"); ;
        }
    }

    private void Timer()
    {
        canvasTime = totalTime - (Time.time - initialTime);
        int minutes = (int)canvasTime / 60;
        int seconds = (int)canvasTime % 60;
        canvasTimerText.text = $"{minutes}:{seconds}";
    }
}
