using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PanelFader : MonoBehaviour {

    public float panelFadeInTime;

    private Image fadePanel;
    private Color currentColor = Color.black;


	// Use this for initialization
	void Start () {

        fadePanel = GetComponent<Image>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Time.timeSinceLevelLoad < panelFadeInTime)
        {
            //fade in the panel
            float alphaChange = Time.deltaTime / panelFadeInTime;
            currentColor.a -= alphaChange;
            fadePanel.color = currentColor;

        }
        else
        {
            gameObject.SetActive(false); //turn off the panel so that the buttons can be clicked, this removes the tick from the top of the screen option object
        }
	}
}
