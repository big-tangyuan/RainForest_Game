using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 100f;
    public float range = 100f;

    public GameObject fpsCam;
    public ParticleSystem muzzleFlash;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {            
            Shoot();
        }

        
        void Shoot()
        {
            muzzleFlash.Play();
            FindObjectOfType<AudioManager>().Play("shoot");
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
                if(hit.transform.tag == "moon")
                {
                    Debug.Log("moonstone~~~~~~~~~~~~"+ hit.transform.name);
                    Moonstone target = hit.transform.GetComponent<Moonstone>();
                    if(target != null)
                    {
                        target.TakeDamage(damage);
                    }
                }
            }
        }
    }
}
