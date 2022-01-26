using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Minigame3Manager : MonoBehaviour
{
    private float mg1Timer;
    private float mg1Time;
    public Slider timeSlider;

    //minigame flame
    public float flameTimer;
    public GameObject flameHolder;
    private float flameScale = 1;

    private void Start()
    {
        mg1Timer = StaticValues.minigameTimer;
        Debug.Log("changed mg1timer");
        timeSlider.maxValue = mg1Timer;
        timeSlider.value = mg1Timer;

        flameTimer = StaticValues.minigameTimer / 10;
    }

    private void Update()
    {
        mg1Time = mg1Timer - Time.timeSinceLevelLoad;
        timeSlider.value = mg1Time;

        if(flameScale <= 0.3f)
        {
            StaticValues.monsterCount += 1;
            StaticValues.minigameTimer = StaticValues.minigameTimer * 0.9f;
            SceneManager.LoadScene("Scene_Main");
        }

        if (mg1Time <= 0)
        {
            MinigameLost();
        }
    }

    private void MinigameLost()
    {
        StaticValues.gameHP -= 1;
        StaticValues.minigameTimer = StaticValues.minigameTimer * 0.9f;
        SceneManager.LoadScene("Scene_Main");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            flameScale = flameScale * 0.9f;
            //Debug.Log("flame is decreasing");
            flameHolder.transform.localScale = new Vector3(flameScale, flameScale, 1);
        }
    }
}
