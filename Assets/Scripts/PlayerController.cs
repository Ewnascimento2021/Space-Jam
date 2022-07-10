using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Image canvasLifeBar;

    [SerializeField]
    private Sprite lifeBar0;
    [SerializeField]
    private Sprite lifeBar1;
    [SerializeField]
    private Sprite lifeBar2;
    [SerializeField]
    private Sprite lifeBar3;
    [SerializeField]
    private Sprite lifeBar4;

    private float upDown;
    private float leftRight;

    private int hp = 4;
    private int hpNew = 4;



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
    }
    private void FixedUpdate()
    {
        if (hpNew != hp)
        {
            switch (hpNew)
            {
                case 4:
                    canvasLifeBar.sprite = lifeBar4;
                    break;
                case 3:
                    canvasLifeBar.sprite = lifeBar3;
                    break;
                case 2:
                    canvasLifeBar.sprite = lifeBar2;
                    break;
                case 1:
                    canvasLifeBar.sprite = lifeBar1;
                    break;
                case 0:
                    canvasLifeBar.sprite = lifeBar0;
                    break;
                default:
                    break;

            }
            hp = hpNew;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
            hpNew = hp - 1;
        }
        else if (other.CompareTag("Laser"))
        {
            hpNew = hp - 1;
        }
    }
}
