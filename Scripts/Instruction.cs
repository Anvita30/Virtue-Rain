using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Instruction : MonoBehaviour
{
    public Button startButton; // Reference to the start button in the Unity Editor
    public Button back; 
    void Start()
    {
        // Add listener to the start button's onClick event
        startButton.onClick.AddListener(StartButton);
        back.onClick.AddListener(backButton);
    }

    public void StartButton()
    {
        // Load the next scene
        SceneManager.LoadScene("ethicssMenu");
    }

    public void backButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
