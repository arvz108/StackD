using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Text scoreText;

    public void Start()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
    }
    // Use this for initialization
    public void ToGame ()
    {
        SceneManager.LoadScene("Game");	
	}
	
}
