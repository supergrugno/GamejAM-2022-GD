using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            StaticValues.gameHP -= 1;
            StaticValues.minigameTimer = StaticValues.minigameTimer * 0.9f;
            SceneManager.LoadScene("Scene_Main");
        }
    }
}
