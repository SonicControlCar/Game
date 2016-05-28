using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    //global variables
    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;

    void OnAwake()
    {
        DontDestroyOnLoad(gameObject);
    }
	// Use this for initialization
	void Start () {

        audioSource = GetComponent<AudioSource>();
	}

    void OnLevelWasLoaded(int level)
    {
        Debug.Log("playing clip: ");
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("playing clip: " + thisLevelMusic.ToString());

        if(thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
