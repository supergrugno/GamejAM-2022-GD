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
