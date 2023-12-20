using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class scoremamanger : MonoBehaviour
{
    public Text scoretext;
    public static scoremamanger instance;

    private void Awake()
    {
        instance = this; 
    }

    static public float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = score.ToString();

    }

    // Update is called once per frame
    public void addPoint()
    {
        score +=1; 
        scoretext.text = score.ToString();
    }

    public void removePoint()
    {
        score -=1; 
        scoretext.text = score.ToString();
    }
}

