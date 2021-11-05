using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hint : MonoBehaviour
{
    public GameObject makeTransparent;

    public void TextInviz()
    {
        makeTransparent.GetComponent<TextMeshProUGUI>().text = ""; 
    }
   
}
