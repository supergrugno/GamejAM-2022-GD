using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyPiece : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
