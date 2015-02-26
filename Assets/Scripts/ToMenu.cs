using UnityEngine;
using System.Collections;

public class ToMenu : MonoBehaviour
{
    private void Update()
    {
        if (Application.loadedLevelName == "end")
            Invoke("LoadMenu", 2);
    }

    private void LoadMenu()
    {
        Application.LoadLevel(0);
    }
}