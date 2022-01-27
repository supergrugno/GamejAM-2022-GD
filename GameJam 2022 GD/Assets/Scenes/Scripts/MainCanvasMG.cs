using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvasMG : MonoBehaviour
{
    public GameObject canvasWin;
    public GameObject canvasLoose;

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

    }
}
