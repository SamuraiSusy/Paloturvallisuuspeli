using UnityEngine;
using System.Collections;

public class TextBox : MonoBehaviour
{
    public GUISkin skin;
    public bool showBox;
    public bool showMessage;
    public string currentMessage;
    private HandleMessages handler;
    public float boxLMultiplier = 2.37037f;
    public float boxTMultiplier = 4.8f;
    public float boxWMultiplier = 2f;
    public float boxHMultiplier = 4f;

	// Use this for initialization
	void Start ()
    {
        handler = GetComponent<HandleMessages>();
        showBox = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        WhichScene();
	}

    private void OnGUI()
    {
        DrawBox();
    }

    private void DrawBox()
    {
        GUI.skin = skin;
        Rect messageBox = new Rect(Screen.width / boxLMultiplier, Screen.height / boxTMultiplier, Screen.width / boxWMultiplier, Screen.height / boxHMultiplier);
        if(showBox)
            GUI.Box(messageBox, currentMessage, skin.GetStyle("test"));
    }

    private void WhichScene()
    {
        if (Application.loadedLevel == 1)
        {
            handler.ChangeMessages(1);
        }
        else if (Application.loadedLevel == 2)
        {
            handler.ChangeMessages(2);
        }
        else if (Application.loadedLevel == 3)
        {
            handler.ChangeMessages(3);
        }
        else if (Application.loadedLevel == 4)
        {
            handler.ChangeMessages(4);
        }
    }
}