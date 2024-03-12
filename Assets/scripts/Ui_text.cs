using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Ui_text : MonoBehaviour
{
    public TMP_Text text;


    void Update()
    {
        text.text = "Score-" + Fruit_spawner.score;
    }
}
