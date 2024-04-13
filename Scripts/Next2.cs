using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Next2 : MonoBehaviour
{
    public Button next2; // Reference to the start button in the Unity Editor
    public Button back;
    void Start()
    {
        // Add listener to the start button's onClick event
        next2.onClick.AddListener(NextButton);
        back.onClick.AddListener(backButton);
    }

    public void NextButton()
    {
        // Load the next scene
        SceneManager.LoadScene("Game2");
    }

    public void backButton()
    {
        // Load the next scene
        SceneManager.LoadScene("ethicssMenu");
    }
    
}
