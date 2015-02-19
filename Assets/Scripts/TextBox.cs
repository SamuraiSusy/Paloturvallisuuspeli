using UnityEngine;
using System.Collections;

public class TextBox : MonoBehaviour
{
    public GUISkin skin;
    public bool showBox;
    public bool showMessage;
    public string currentMessage;
    private HandleMessages handler;

	// Use this for initialization
	void Start ()
    {
        handler = GetComponent<HandleMessages>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        WhichScene();
        Debug.Log(currentMessage);
        Debug.Log(handler.curBoxContent);
        //Debug.Log();
	}

    private void OnGUI()
    {
        DrawBox();
    }

    private void DrawBox()
    {
        GUI.skin = skin;
        Rect messageBox = new Rect(100, 100, 200, 100);
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