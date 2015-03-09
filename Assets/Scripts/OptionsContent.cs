using UnityEngine;
using System.Collections;

public class OptionsContent : MonoBehaviour
{
    public string[][] optionsArray;
    public string[] options1;
    public string[] options2;
    public string[] options3;
    public string[] options4;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    private void SetUpOptions1()
    {
        options1 = new string[]
        {
            "",
            "",
            ""
        };
    }

    private void SetUpOptions2()
    {
        options2 = new string[]
        {
            "",
            "",
            ""
        };
    }

    private void SetUpOptions3()
    {
        options3 = new string[]
        {
            "",
            "",
            ""
        };
    }

    private void SetUpOptions4()
    {
        options4 = new string[]
        {
            "",
            "",
            ""
        };
    }
}
