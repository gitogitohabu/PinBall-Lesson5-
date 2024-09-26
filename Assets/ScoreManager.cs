using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            AddScore(10);
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            AddScore(20);
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            AddScore(30);
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            AddScore(40);
        }
    }

    void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Update is called once per frame
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}