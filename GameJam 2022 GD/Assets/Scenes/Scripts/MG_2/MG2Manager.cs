using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MG2Manager : MonoBehaviour
{
    public GameObject dirtyObj;
    private int dirtyAmount = 5;
    private RectTransform rt;

    //timer
    private float mg1Timer;
    private float mg1Time;
    public Slider timeSlider;

    private void Start()
    {
        rt = this.gameObject.GetComponent<RectTransform>();

        mg1Timer = StaticValues.minigameTimer;
        Debug.Log("changed mg1timer");
        timeSlider.maxValue = mg1Timer;
        timeSlider.value = mg1Timer;

        //difficulty part
        dirtyAmount = (int)(50 / StaticValues.minigameTimer);

        for (int i = 0; i < dirtyAmount; i++)
        {
            GameObject thisPiece = Instantiate(dirtyObj, new Vector3(Random.Range(rt.rect.xMin, rt.rect.xMax),
                Random.Range(rt.rect.yMin, rt.rect.yMax), 0) + transform.position, Quaternion.identity);

            thisPiece.transform.parent = this.gameObject.transform;
        }
    }

    private void Update()
    {
        mg1Time = mg1Timer - Time.timeSinceLevelLoad;
        timeSlider.value = mg1Time;

        CheckIfWin();
        if (mg1Time <= 0)
        {
            EndMinigame();
        }
    }

    private void EndMinigame()
    {
        StaticValues.gameHP -= 1;
        StaticValues.minigameTimer = StaticValues.minigameTimer * 0.9f;
        SceneManager.LoadScene("Scene_Main");
    }

    private void CheckIfWin()
    {
        if(gameObject.transform.childCount <= 0)
        {
            StaticValues.monsterCount += 1;
            StaticValues.minigameTimer = StaticValues.minigameTimer * 0.9f;
            SceneManager.LoadScene("Scene_Main");
        }
    }
}

