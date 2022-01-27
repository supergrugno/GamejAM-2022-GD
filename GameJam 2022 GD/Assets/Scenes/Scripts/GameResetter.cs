using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResetter : MonoBehaviour
{
    private void Start()
    {
        StaticValues.monsterCount = 0;
        StaticValues.gameHP = 3;
        StaticValues.gameHPcontroller = 3;
        StaticValues.gameIsOn = false;
        StaticValues.minigameTimer = 15;
    }
}
