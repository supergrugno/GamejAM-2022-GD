using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthRandomizer : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        var rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = RandomVector(-2f, 2f);
    }

    private Vector2 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);

        return new Vector2(x, y);
    }
}
