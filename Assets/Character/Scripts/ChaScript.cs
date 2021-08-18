using UnityEngine;
using System.Collections;

public class ChaScript : MonoBehaviour
{
    private Animator anim;
    bool start_game = false;
    bool run = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey("w"))
        {
            start_game = true;
            run = true;
        }
        else
        {
            //anim.SetBool("Run", false);
        }
        if(start_game == true && run == true)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey("a"))
        {
            run = false;
            anim.SetBool("Run", false);
            anim.SetBool("RunLeft", true);
        }
        else
        {
            run = true;
            anim.SetBool("RunLeft", false);
        }

        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey("d"))
        {
            run = false;
            anim.SetBool("Run", false);
            anim.SetBool("RunRight", true);
        }
        else
        {
            run = true;
            anim.SetBool("RunRight", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("RunBack", true);
        }
        else
        {
            anim.SetBool("RunBack", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            
            anim.SetBool("Attack", true);
            run = false;
        }
        else
        {
            run = true;
            anim.SetBool("Attack", false);
        }
    }
}
