using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    public Button back;
    public Button one;
    public Button two;
    public Button three;
    public Button four;
    public Button five;
    public Button six;
    public Button seven;
    public Button eight;
    public Button nine;
    public Button ten;
    public Button eleven;
    public Button twelve;
   void Start()
    {
        // Add listener to the start button's onClick event
        back.onClick.AddListener(backButton);
        one.onClick.AddListener(oneButton);
        two.onClick.AddListener(twoButton);
        three.onClick.AddListener(threeButton);
        four.onClick.AddListener(fourButton);
        five.onClick.AddListener(fiveButton);
        six.onClick.AddListener(sixButton);
        seven.onClick.AddListener(sevenButton);
        eight.onClick.AddListener(eightButton);
        nine.onClick.AddListener(nineButton);
        ten.onClick.AddListener(tenButton);
        eleven.onClick.AddListener(elevenButton);
        twelve.onClick.AddListener(twelveButton);
    }

    public void backButton()
    {
        // Load the next scene
        SceneManager.LoadScene("MainMenu");
    }
    public void oneButton()
    {
        // Load the next scene
        SceneManager.LoadScene("1");
    }

    public void twoButton()
    {
        // Load the next scene
        SceneManager.LoadScene("2");
    }

    public void threeButton()
    {
        // Load the next scene
        SceneManager.LoadScene("3");
    }

    public void fourButton()
    {
        // Load the next scene
        SceneManager.LoadScene("4");
    }

    public void fiveButton()
    {
        // Load the next scene
        SceneManager.LoadScene("5");
    }

    public void sixButton()
    {
        // Load the next scene
        SceneManager.LoadScene("6");
    }

    public void sevenButton()
    {
        // Load the next scene
        SceneManager.LoadScene("7");
    }
    public void eightButton()
    {
        // Load the next scene
        SceneManager.LoadScene("8");
    }
    public void nineButton()
    {
        // Load the next scene
        SceneManager.LoadScene("9");
    }
    public void tenButton()
    {
        // Load the next scene
        SceneManager.LoadScene("10");
    }
    public void elevenButton()
    {
        // Load the next scene
        SceneManager.LoadScene("11");
    }
    public void twelveButton()
    {
        // Load the next scene
        SceneManager.LoadScene("12");
    }

}

