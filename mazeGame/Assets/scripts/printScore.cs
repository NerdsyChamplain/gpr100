using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class printScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = totalScore.fullScore.ToString();
    }
}
