using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moonstone : MonoBehaviour
{
    public float health = 50f;
    public ParticleSystem bloom;
    public GameObject addmoon_image;

    public void TakeDamage(float amount)
    {
        Debug.Log("behitted");
        health -= amount;
        if(health <= 0f)
        {
            Disappear();
        }
    }
    void Disappear()
    {
        FindObjectOfType<AudioManager>().Play("get_moon");  //music
        bloom.Play();     //bloom particle system
        Destroy(gameObject);      //moonstone disappear
        if(addmoon_image.activeSelf == false)
        {
            addmoon_image.SetActive(true);
        }
        else
        {
            addmoon_image.SetActive(false);
            addmoon_image.SetActive(true);
        }
             
        FindObjectOfType<score>().destroyedmoon += 1f;     //sum of destoryed moonstone +1
        FindObjectOfType<AudioManager>().sum_score += 1f;
    }
}
