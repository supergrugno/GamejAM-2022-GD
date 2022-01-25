using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject monsterPrefab;
    public float radius = 5;
    private RectTransform rt;

    private void Start()
    {
        rt = GetComponent<RectTransform>();
        for (int i = 0; i < StaticValues.monsterCount; i++)
        {
            Instantiate(monsterPrefab, new Vector3(Random.Range(rt.rect.xMin, rt.rect.xMax),
                Random.Range(rt.rect.yMin, rt.rect.yMax),0) + transform.position, Quaternion.identity);
        }
    }
}
