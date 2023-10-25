using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        totalScore.fullScore = score;
    }
}
