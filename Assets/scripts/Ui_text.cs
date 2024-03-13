using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Ui_text : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text START;
    public TMP_Text End;

    private void Start()
    {
        START.text = "Left click pls";
    }

    void Update()
    {
        
        text.text = "Score-" + Fruit_spawner.score;
        
        if (Input.GetMouseButtonUp(0))
        {
            START.text = "";
        }
        


    }
}
