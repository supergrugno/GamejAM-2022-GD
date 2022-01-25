using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMonsterGenerator : MonoBehaviour
{
    [SerializeField] private Sprite[] arms;
    [SerializeField] private Sprite[] bodies;
    [SerializeField] private Sprite[] heads;
    [SerializeField] private Sprite[] legs;

    [SerializeField] private GameObject _arms;
    [SerializeField] private GameObject _body;
    [SerializeField] private GameObject _head;
    [SerializeField] private GameObject _legs;


    private void Start()
    {
        _arms.GetComponent<SpriteRenderer>().sprite = arms[Random.Range(0, arms.Length)];
        _body.GetComponent<SpriteRenderer>().sprite = bodies[Random.Range(0, bodies.Length)];
        _head.GetComponent<SpriteRenderer>().sprite = heads[Random.Range(0, heads.Length)];
        _legs.GetComponent<SpriteRenderer>().sprite = legs[Random.Range(0, legs.Length)];
    }
}
