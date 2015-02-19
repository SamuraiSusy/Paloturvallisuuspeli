using UnityEngine;
using System.Collections;

public class TextBoxContent : MonoBehaviour
{
    public string[][] dialogies;
    public string[] beginning;
    public string[] fireStarts;
    public string[] movingToEteinen;
    public string[] movingToYard;
    public string[] movingToKatos;

	// Use this for initialization
	void Start ()
    {
        SetUpBeginning();
        SetUpFireStarts();
        SetUpMovingToEteinen();
        SetUpMovingToYard();
        SetUpMovingToKatos();
        SetUpDialogies();
	}

    private void SetUpDialogies()
    {
        dialogies = new string[5][];

        dialogies[0] = beginning;
        dialogies[1] = fireStarts;
        dialogies[2] = movingToEteinen;
        dialogies[3] = movingToYard;
        dialogies[4] = movingToKatos;
    }

    private void SetUpBeginning()
    {
        beginning = new string[]
        {
            "Olipa kerran pieni poika.",
            "Loppu."
        };
    }

    private void SetUpFireStarts()
    {
        beginning = new string[]
        {
            "Palo alkoi.",
            "Loppu."
        };
    }

    private void SetUpMovingToEteinen()
    {
        beginning = new string[]
        {
            "Lapset siirtyivät eteiseen.",
            "Loppu."
        };
    }

    private void SetUpMovingToYard()
    {
        beginning = new string[]
        {
            "Lapset menivät pihalle parijonossa.",
            "Loppu."
        };
    }

    private void SetUpMovingToKatos()
    {
        beginning = new string[]
        {
            "Kaikki olivat iloisina katoksessa.",
            "Loppu."
        };
    }
}
