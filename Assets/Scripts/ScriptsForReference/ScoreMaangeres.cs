using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMaangeres : MonoBehaviour
{
    public Transform playerTransform;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    private float highestYPosition = 0f;
    private float highScore = 0f;

    private void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        highScoreText.text = "High Score: " + highScore.ToString("F1");
    }

    private void Update()
    {
        float currentYPosition = playerTransform.position.y;
        if (currentYPosition > highestYPosition)
        {
            highestYPosition = currentYPosition;
            scoreText.text = "Score: " + highestYPosition.ToString("F1");

            if (highestYPosition > highScore)
            {
                highScore = highestYPosition;
                highScoreText.text = "High Score: " + highScore.ToString("F1");
                PlayerPrefs.SetFloat("HighScore", highScore);
            }
        }
    }
}
