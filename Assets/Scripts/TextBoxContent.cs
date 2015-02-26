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
	private void Awake ()
    {
        SetUpBeginning();
        SetUpFireStarts();
        SetUpMovingToEteinen();
        SetUpMovingToYard();
        SetUpMovingToKatos();
        SetUpDialogies();

        //Debug.Log(dialogies[0].Length + " dialogies lenght");
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
        fireStarts = new string[]
        {
            "Palo alkoi.",
            "Se alkoi taas.",
            "Ja taas",
            "Palo alkoi.",
            "Loppu."
        };
    }

    private void SetUpMovingToEteinen()
    {
        movingToEteinen = new string[]
        {
            "Lapset siirtyivät eteiseen.",
            "Loppu."
        };
    }

    private void SetUpMovingToYard()
    {
        movingToYard = new string[]
        {
            "Lapset menivät pihalle parijonossa.",
            "Loppu."
        };
    }

    private void SetUpMovingToKatos()
    {
        movingToKatos = new string[]
        {
            "Kaikki olivat iloisina katoksessa.",
            "Loppu."
        };
    }
}
