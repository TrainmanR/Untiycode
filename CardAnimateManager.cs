using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations; 

public class CardAnimateManager : MonoBehaviour
{
    public Animator animator;
    public float Card2 = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        animator.SetFloat("Card", 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            if(Card2==-1){
                Card2=(float)2;
            }
            else{
                Card2=Card2+(float)1;
            }
            if (Card2==(float)4){
                Card2=(float)-1;
            }
            

            animator.SetFloat("Card", Card2);
        }    
    }
}
