using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCounterScript : MonoBehaviour
{
    //this UI setup shows the amount of monsters captured
    private string textString;
    private TextMeshProUGUI textmeshPro;

    private void Start()
    {
        textmeshPro = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textString = StaticValues.monsterCount.ToString();
        textmeshPro.SetText(textString);

        //testing keys 
        //TO REMOVE IN END PRODUCT
        if (Input.GetKeyDown(KeyCode.E))
        {
            StaticValues.monsterCount += 1;
        }
    }
}
