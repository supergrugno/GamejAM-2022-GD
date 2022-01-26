using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyPiece : MonoBehaviour
{
    public Sprite[] _sprites;
    private SpriteRenderer sr;

    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = _sprites[Random.Range(0, _sprites.Length)];
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
