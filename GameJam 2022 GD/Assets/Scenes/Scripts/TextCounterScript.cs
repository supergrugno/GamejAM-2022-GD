using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCounterScript : MonoBehaviour
{
    //this UI setup shows the amount of monsters captured
    private string textString = "placeholder";
    private TextMeshProUGUI textmeshPro;

    private void Start()
    {
        textmeshPro = this.gameObject.GetComponent<TextMeshProUGUI>();
        textString = StaticValues.monsterCount.ToString();
        textmeshPro.SetText(textString);
    }
}
