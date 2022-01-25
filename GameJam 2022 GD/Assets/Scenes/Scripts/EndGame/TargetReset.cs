using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetReset : MonoBehaviour
{
    public float radius = 1;
    private float timeSpace;
    public float minTime = 3;
    public float maxTime = 7;

    private GameObject controllerObj;
    private RectTransform rt;

    private void Start()
    {
        controllerObj = GameObject.FindGameObjectWithTag("GameController");
        rt = controllerObj.GetComponent<RectTransform>();
        timeSpace = Random.Range(minTime, maxTime);
        InvokeRepeating("NewPosition", timeSpace, timeSpace);
    }

    private void NewPosition()
    {
        this.gameObject.transform.position = new Vector3(Random.Range(rt.rect.xMin, rt.rect.xMax),
                Random.Range(rt.rect.yMin, rt.rect.yMax), 0) + transform.position;
    }
}
