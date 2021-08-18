using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMusic : MonoBehaviour
{
    public void PlayButtonMusic()
    {
        FindObjectOfType<AudioManager>().Play("button");
    }
}
