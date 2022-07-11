using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform aim;
    [SerializeField]
    private float timeInterval;

    [SerializeField]
    private Rigidbody2D projectile;
    private float lastTimeStamp;



    [SerializeField]
    private float speed;

    [SerializeField]
    private AudioSource soundCannon;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }
    private void Timer()

    {
        if (Time.time - lastTimeStamp >= timeInterval)
        {
            lastTimeStamp = Time.time;
            Fire();

        }
    }

    private void Fire()
    {
        Rigidbody2D newProjectile = Instantiate(projectile, aim.position, aim.rotation);
        newProjectile.AddForce(transform.up * speed);
        soundCannon.Play();
    }
}



