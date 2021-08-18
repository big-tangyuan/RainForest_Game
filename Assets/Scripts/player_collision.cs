using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{

    public player_movement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<AudioManager>().Play("player_collision");
            Debug.Log(collisionInfo.collider.name);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
