using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelsMenu : MonoBehaviour
{
    public Button back;
    public Button[] buttons;
    public Button resetButton;
    public TextMeshProUGUI bestScoreText;

    // Define the base score and score increment
    public int baseScore = 20;
    public int scoreIncrement = 10;

    void Start()
    {
        // Add listeners to button onClick events
        back.onClick.AddListener(backButton);
        resetButton.onClick.AddListener(ResetProgress);

        int bestScore = PlayerPrefs.GetInt(ScoreController.HighScoreKey, 0);
        bestScoreText.text = "Best Score: " + bestScore.ToString();
    }

    private void Awake()
    {
        // Load unlocked level from PlayerPrefs
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        UpdateButtonInteractability(unlockedLevel);
    }

    public void OpenLevel(int levelId)
    {
        // Calculate the target score based on the level number
        int targetScore = baseScore + (levelId - 1) * scoreIncrement;

        // Pass the target score to the next scene
        PlayerPrefs.SetInt("TargetScore", targetScore);

        string levelName = levelId.ToString();
        SceneManager.LoadScene(levelName);
    }

    public void backButton()
    {
        // Load the instructions scene
        SceneManager.LoadScene("Instructions");
    }

    public void ResetProgress()
    {
        // Reset unlocked level to 1
        PlayerPrefs.SetInt("UnlockedLevel", 1);

        PlayerPrefs.SetInt(ScoreController.HighScoreKey, 0);
        // Reload the scene to reflect changes
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void UpdateButtonInteractability(int unlockedLevel)
    {
        // Update button interactability based on unlocked level
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = i < unlockedLevel;
        }
    }
}
