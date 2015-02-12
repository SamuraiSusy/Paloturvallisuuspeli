using UnityEngine;
using System.Collections;

// works with up/down arrow keys
// and select with space
public class Menu : MonoBehaviour
{
    //private int buttonCount = 3;
    private string[] buttons = new string[3]
                                {
                                    "Start",
                                    "Options",
                                    "Exit"
                                };
    private int selected;

	// Use this for initialization
    private void Start()
    {
        selected = 0;
	}
	
	// Update is called once per frame
    private void Update()
    {
        UseMenu();
	}

    // controls the button selection
    private int MenuSelection(string[] buttonsArray, int selectedItem, string direction)
    {
        if(direction == "up")
        {
            if(selectedItem == 0)
            {
                selectedItem = buttonsArray.Length - 1;
            }
            else
            {
                selectedItem -= 1;
            }
        }

        if(direction == "down")
        {
            if(selectedItem == buttonsArray.Length - 1)
            {
                selectedItem = 0;
            }
            else
            {
                selectedItem += 1;
            }
        }

        return selectedItem;
    }

    private void UseMenu()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            selected = MenuSelection(buttons, selected, "up");

        if (Input.GetKeyDown(KeyCode.DownArrow))
            selected = MenuSelection(buttons, selected, "down");
    }

    // draws buttons and sets the next button
    private void DrawAndSetUpMenu()
    {
        GUI.SetNextControlName(buttons[0]);

        if (GUI.Button(new Rect(0, 0, 100, 100), buttons[0]))
        {
            Debug.Log("go to next scene");
        }

        GUI.SetNextControlName(buttons[1]);

        if (GUI.Button(new Rect(0, 100, 100, 100), buttons[1]))
        {
            Debug.Log("options, sounds on/off");
        }

        GUI.SetNextControlName(buttons[2]);

        if (GUI.Button(new Rect(0, 200, 100, 100), buttons[2]))
        {
            Application.Quit();
            Debug.Log("exited game");
        }

        GUI.FocusControl(buttons[selected]);
    }

    private void OnGUI()
    {
        DrawAndSetUpMenu();
    }
}