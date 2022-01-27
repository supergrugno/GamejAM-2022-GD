using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvasMG : MonoBehaviour
{
    public GameObject canvasWin;
    public GameObject canvasLoose;

    public GameObject flower1;
    public GameObject flower2;

    private void Start()
    {
        if(StaticValues.gameHPcontroller == StaticValues.gameHP)
        {
            if(StaticValues.gameIsOn == false)
            {
                StaticValues.gameIsOn = true;
            }else if(StaticValues.gameIsOn == true)
            {
                canvasWin.SetActive(true);
            }
        }else if (StaticValues.gameHPcontroller != StaticValues.gameHP)
        {
            canvasLoose.SetActive(true);
            StaticValues.gameHPcontroller = StaticValues.gameHP;
        }

        if (StaticValues.gameHP == 3)
        {
            flower1.SetActive(true);
            flower2.SetActive(true);
        }
        else if (StaticValues.gameHP == 2)
        {
            flower2.SetActive(false);
        }else if (StaticValues.gameHP == 1)
        {
            flower1.SetActive(false);
            flower2.SetActive(false);
        }
    }
}
