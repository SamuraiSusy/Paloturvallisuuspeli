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
    public float buttonOffsetMultiplier = 9.6f;

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

            offset += Screen.height / buttonOffsetMultiplier;
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
                Application.LoadLevel(5); // end scene, koska ohjescenessä ei oo viel mitää
                break;
            case 2:
                Application.Quit();
                break;
        }
    }
}