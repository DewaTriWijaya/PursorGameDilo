using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    int score = 0;
    Text scoreText;

    private void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    public void Score(int up)
    {
        score += up;
        UpScore();
    }

    private void UpScore()
    {
        scoreText.text = "Score: " + score;
    }
}
