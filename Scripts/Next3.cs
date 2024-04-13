using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Next3 : MonoBehaviour
{
    public Button next; // Reference to the start button in the Unity Editor
    public Button back;
    void Start()
    {
        // Add listener to the start button's onClick event
        next.onClick.AddListener(NextButton);
        back.onClick.AddListener(backButton);
    }

    public void NextButton()
    {
        // Load the next scene
        SceneManager.LoadScene("Game3");
    }

    public void backButton()
    {
        // Load the next scene
        SceneManager.LoadScene("ethicssMenu");
    }
}
