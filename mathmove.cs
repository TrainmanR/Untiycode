using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TestTools;

public class mathmove : MonoBehaviour
{
    public Animator animator; 
    public float card; 
    public Rigidbody2D rigid; 

    // Start is called before the first frame update
    void Start()
    {
        card = 1;
        animator.SetFloat("mathman", 1);
        rigid.velocity = Vector2.up *10; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetFloat("mathman", card + 1);
        }

    }
}
