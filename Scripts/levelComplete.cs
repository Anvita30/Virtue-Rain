using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public Button nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        nextLevel.onClick.AddListener(NextButton);
    }

    public void NextButton()
    {
        // Load the next scene
        SceneManager.LoadScene("ethicssMenu");
    }
   
}
