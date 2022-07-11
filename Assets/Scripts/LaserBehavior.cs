using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject laser;
    [SerializeField]
    private float timeInterval;
    private float lastTimeStamp;

    [SerializeField]
    private AudioSource soundLaser;

    private bool isActive;

    void Update()
    {
        Timer();
        

    }

    private void Timer()
    {
        if (Time.time - lastTimeStamp >= timeInterval)
        {
            lastTimeStamp = Time.time;
            if(isActive)
            {
                laser.SetActive(false);
                isActive = false;
            }
            else
            {
                laser.SetActive(true);
                isActive = true;
                soundLaser.Play();
            }
        }
    }
}
