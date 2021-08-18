using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sumscoretext : MonoBehaviour
{
    public Text sum_score;

    void Update()
    {
        float Score = FindObjectOfType<AudioManager>().sum_score;
        sum_score.text = Score.ToString();
    }

    public void ClearScore()
    {
        FindObjectOfType<AudioManager>().sum_score = 0f;
    }
}
