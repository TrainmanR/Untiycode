using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Scorebaord : MonoBehaviour
{
    public Text scoretext;
    public static Scorebaord instance;

    private void Awake()
    {
        instance = this; 
    }

    static public float score1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = score1.ToString();

    }

    // Update is called once per frame
    public void addPoint()
    {
        score1 +=1; 
        scoretext.text = score1.ToString();
    }
     public void removePoint()
    {
        score1 -=1; 
        scoretext.text = score1.ToString();
    }
}
