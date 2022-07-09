using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float speed;

    private float upDown;
    private float leftRight;

    private Vector2 newVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        upDown = Input.GetAxis("Vertical");
        leftRight = Input.GetAxis("Horizontal");
        if (upDown != 0) 
        {
            rb.AddForce(speed * transform.up * upDown);
        }
        if (leftRight != 0)
        {
            rb.AddForce(speed * transform.right * leftRight);
        }

        //rb.velocity = newVelocity;
    }
}
