using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BriefingScript : MonoBehaviour
{
    [SerializeField]
    private GameObject textBriefing;
    [SerializeField]
    private float speed;
    private void FixedUpdate()
    {
        textBriefing.transform.position = new Vector2(textBriefing.transform.position.x , textBriefing.transform.position.y + speed);
    }
}
