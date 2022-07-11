using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text startGameText;
    [SerializeField]
    private TMP_Text selectedLevelText;
    [SerializeField]
    private TMP_Text quitText;

    private int lineSelected = 1;

    private int level = 1;

    [SerializeField]
    private AudioSource soundBackground;
    void Start()
    {
        soundBackground.Play();
    }
    void Update()
    {
        Inputs();
        if (lineSelected == 1)
        {
            startGameText.outlineColor = new Color(0, 1, 0);
            selectedLevelText.outlineColor = new Color(0, 1, 0);
            quitText.outlineColor = new Color(1, 1, 0);
        }

        else if (lineSelected == 2)
        {
            startGameText.outlineColor = new Color(1, 1, 0);
            selectedLevelText.outlineColor = new Color(1, 1, 0);
            quitText.outlineColor = new Color(0, 1, 0);         
        }
        selectedLevelText.text = $"level {level}";


    }

    private void Inputs()
    {
        if (Input.GetButtonDown("Right"))
            level++;
        if (Input.GetButtonDown("Left"))
            level--;

        if (level > 3)
            level = 3;
        else if (level < 1)
            level = 1;

        if (Input.GetButtonDown("Up"))
            lineSelected = 1;
        if (Input.GetButtonDown("Down"))
            lineSelected = 2;

        if (Input.GetButtonDown("Fire1"))
        {
            if(lineSelected == 1)
            {
                if(level == 1)
                    SceneManager.LoadScene("Fase1");
                else if (level ==2)
                    SceneManager.LoadScene("Fase2");
                else if (level == 3)
                    SceneManager.LoadScene("Fase3");
            }
            else
            {
                Application.Quit();
            }
        }

    }
}
