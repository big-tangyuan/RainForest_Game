
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public Rigidbody Rb;


    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    bool start_game = false;
    bool run = false;
    
    void FixedUpdate()
    {
        // Add a forward force
        if(start_game == true && run == true)
        {
            Rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            run = false;
        }
        else
        {
            run = true;
        }


            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d") )   //向右
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))   //向左
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))     //向前加速
        {
            start_game = true;
            Rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Rb.position.y <= -30f)     //跌落则游戏结束
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
