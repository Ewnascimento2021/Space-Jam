using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour
{
    private bool hasPowerup;
    [SerializeField]
    private float powerupStrength;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector2 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            playerRb.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
}
