using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    // scene management and loading
    [SerializeField] private string mainMenuScene;
    [SerializeField] private string MainScene;
    [SerializeField] private string endScreenScene;
    [SerializeField] private string[] minigameScenes;

    //Gameplay and loose state
    public int HeartsHP = 3;

    private void Update()
    {
        //check HP to see if the game has to end
        HeartsHP = StaticValues.gameHP;
        if(HeartsHP<= 0)
        {
            LoadEndScreen();
        }
    }


    // scene management and loading
    public void LoadMinigame()
    {
        SceneManager.LoadScene(minigameScenes[Random.Range(0, minigameScenes.Length)]);
    }

    public void LoadEndScreen()
    {
        SceneManager.LoadScene(endScreenScene);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(MainScene);
    }
}
