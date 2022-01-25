using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BulletSpawner : MonoBehaviour
{
    //bullets
    [SerializeField] private float spawnRadius = 7;
    public float timeSpawn = 1.5f;

    public GameObject bulletPrefab;

    //timer
    [SerializeField] private int mg1Timer;
    public Slider timeSlider;

    private void Start()
    {
        mg1Timer = StaticValues.minigameTimer;
        timeSlider.maxValue = mg1Timer;
        timeSlider.value = mg1Timer;

        StartCoroutine(SpawnABullet());
    }

    private void Update()
    {
        float time = mg1Timer - Time.time;

        timeSlider.value = time;
        if(time <= 0)
        {
            EndMinigame();
        }
    }

    IEnumerator SpawnABullet()
    {
        Vector2 spawnPos = GameObject.Find("Heart").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(timeSpawn);
        StartCoroutine(SpawnABullet());
    }

    private void EndMinigame()
    {
        StaticValues.monsterCount += 1;
        SceneManager.LoadScene("Scene_Main");
    }
}
