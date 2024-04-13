using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public const string HighScoreKey = "HighScore";
    public TextMeshProUGUI scoreText;
    private int score;

    private bool levelCompleted = false;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

    // Fetch the target score from PlayerPrefs
        int targetScore = PlayerPrefs.GetInt("TargetScore", 30);

    // Check if the score reaches the target
        if (score >= targetScore && !levelCompleted)
        {
            LevelCompleted();
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "badEthics")
        {
            SceneManager.LoadScene("ethicssMenu");
        }
    }

    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "goodEthics")
        {
            Destroy(target.gameObject);
            score += 4;
        }
    }

    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, score);
        }
    }

    private void LevelCompleted()
    {
        // Set levelCompleted flag to true to prevent multiple calls
        levelCompleted = true;

        // Show level completed message
        Debug.Log("Level Completed!");

        // Unlock next level
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        PlayerPrefs.SetInt("UnlockedLevel", unlockedLevel + 1);

        // Load the ethics menu scene
        SceneManager.LoadScene("LevelComplete");
    }
}
