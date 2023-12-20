using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Manager : MonoBehaviour
{

    public GameObject[] Levels;
    static public int Player; 
    public GameObject[] tart; 
    static public float CONTROL; 

    void Start()
    {
      CONTROL = 0; 
    }
    void Update()
    {
        if (Dialogue.START == 1 && (CONTROL == 0)) 
        {
            if(Input.GetKeyDown(KeyCode.Q)) 
            {
                
                    Player = 2;
                    CONTROL = 1;  
                
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                    Player = 1;
                    CONTROL = 2; 
            }
        }
    }

    int currentLevel;
    public void wrongAnswer()
    {
        if(Player == 1)
        {
            CONTROL = 1;  
            Player = 2;
        }
        else 
        {
            CONTROL = 2;
            Player = 1; 
        }
        
            
    }

    public void correctAnswer()
    {


        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);
            
            currentLevel++;
            Levels[currentLevel].SetActive(true);
            
            if (Player == 1)
            {
                Scorebaord.instance.addPoint(); 
                CONTROL = 0; 
                Player = 0; 
            }
            if (Player ==2)
            {
                scoremamanger.instance.addPoint();
                CONTROL = 0; 
                Player = 0; 
            }
        }
        else
        {
            Levels[currentLevel].SetActive(false);
            CONTROL = 5; 
        }
    }




}