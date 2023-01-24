using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;

  

    void Update()
    {
        score = (int)Time.time;
        scoreText.text = "Score : " + score.ToString() + "s";
    }


}