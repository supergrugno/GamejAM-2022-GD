using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetReset : MonoBehaviour
{
    public float radius = 1;
    private float timeSpace;
    public float minTime = 3;
    public float maxTime = 7;

    private void Start()
    {
        timeSpace = Random.Range(minTime, maxTime);
        InvokeRepeating("NewPosition", timeSpace, timeSpace);
    }

    private void NewPosition()
    {
        this.gameObject.transform.position = Random.insideUnitCircle * radius;
    }
}
