using UnityEngine;
using System.Collections;

public class TextBox : MonoBehaviour
{
    public GUISkin skin;
    public bool showBox;
    public bool showMessage;
    public string currentMessage;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    private void DrawBox()
    {
        GUI.skin = skin;
        Rect messageBox = new Rect();
        GUI.Box(messageBox, currentMessage, skin.GetStyle(""));
    }
}