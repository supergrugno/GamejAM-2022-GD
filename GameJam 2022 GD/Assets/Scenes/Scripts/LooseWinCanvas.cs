using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseWinCanvas : MonoBehaviour
{
    private void Awake()
    {
        Invoke("DeactivateGO", 1);
    }

    private void DeactivateGO()
    {
        this.gameObject.SetActive(false);
    }
}
