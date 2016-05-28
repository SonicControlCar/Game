﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    void Start()
    {
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
        SceneManager.LoadScene(name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public void LoadNextLevel()
    {
        // Application.LoadLevel(Application.loadedLevel + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
