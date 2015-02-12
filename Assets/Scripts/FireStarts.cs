using UnityEngine;
using System.Collections;

public class FireStarts : MonoBehaviour
{

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
        GUI.Box(new Rect(Screen.width / 2, Screen.height / 1.4f, Screen.width / 2.1f, Screen.height / 4), "test");
    }
}
