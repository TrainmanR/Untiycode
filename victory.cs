using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class victory : MonoBehaviour
{
    public Text text; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.CONTROL == 5)
        {
            if (Scorebaord.score1 > scoremamanger.score)
            {
                
                text.text = "PLAYER 1 WINS!";
            }
            if (Scorebaord.score1 < scoremamanger.score)
            {
                text.text = "PLAYER 2 WINS!";
            }
            if (Scorebaord.score1 == scoremamanger.score)
            {
                text.text = "IT'S A TIE!";
            }
        }
    }
}
