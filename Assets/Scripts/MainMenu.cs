using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public GUISkin skin;
    // jos näitä arvoja muuttaa, scripti pitää poistaa ja laittaa takaisin objektiin
    // jos arvoja muuttaa unity puolella, nämä arvot pysyvät koodissa samoina,
    // mutta muuttuvat inspectorissa ja pelissä
    public string[] buttonNames = new string[] { "Pelaa", "Ohjeet", "Lopeta" };
    public float buttonLMultiplier = 2.37037f;
    public float buttonTMultiplier = 4.8f;
    public float buttonWMultiplier = 4.8f;
    public float buttonHMultiplier = 9.6f;
    public float buttonOffset = 50f; // toimii vain 640x480 resolla tällä hetkellä

	// Use this for initialization
	private void Start ()
    {
        
	}
	
	// Update is called once per frame
	private void Update () 
    {
	}

    private void OnGUI()
    {
        GUI.skin = skin;
        float offset = 0;
        
        for(int i = 0; i < buttonNames.Length; i++)
        {
            Rect buttonRect = new Rect(Screen.width / buttonLMultiplier, Screen.height / buttonTMultiplier + offset,
                                        Screen.width / buttonWMultiplier, Screen.height / buttonHMultiplier);
            if(GUI.Button(buttonRect, buttonNames[i], skin.GetStyle("buttontest")))
            {
                ButtonContent(i);
            }

            offset += buttonOffset;
        }
    }

    private void ButtonContent(int id)
    {
        switch(id)
        {
            case 0:
                Application.LoadLevel(1);
                break;
            case 1:
                Application.LoadLevel(5);
                break;
            case 2:
                Application.Quit();
                break;
        }
    }
}