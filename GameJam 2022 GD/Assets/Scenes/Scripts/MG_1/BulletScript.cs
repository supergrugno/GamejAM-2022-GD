using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private GameObject target;
    public float bulletSpeed = 1.5f;

    private void Start()
    {
        target = GameObject.Find("Heart");
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, bulletSpeed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
