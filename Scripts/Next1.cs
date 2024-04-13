using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Next : MonoBehaviour
{
    public Button next;
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
        SceneManager.LoadScene("Game1");
    }

    public void backButton()
    {
        // Load the next scene
        SceneManager.LoadScene("ethicssMenu");
    }

}
