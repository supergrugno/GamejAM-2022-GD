using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject monsterPrefab;
    public float radius = 5;

    private void Update()
    {
        if(this.gameObject.transform.childCount< StaticValues.monsterCount)
        {
            GameObject monster = Instantiate(monsterPrefab, Random.insideUnitCircle * radius, Quaternion.identity);
            monster.transform.SetParent(this.gameObject.transform);
        }
    }
}
