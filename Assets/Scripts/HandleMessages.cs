using UnityEngine;
using System.Collections;

public class HandleMessages : MonoBehaviour
{
    private TextBox txtbox;
    private TextBoxContent boxContent;
    public string[] curBoxContent;
    public int messageCount;

	// Use this for initialization
	void Start ()
    {
        txtbox = GameObject.FindGameObjectWithTag("TextBox").GetComponent<TextBox>();
        boxContent = GameObject.FindGameObjectWithTag("Content").GetComponent<TextBoxContent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void ChangeMessages()
    {

    }

    private void WriteMessages()
    {
        for(int i = 0; i < boxContent.dialogies.Length; i++)
        {
            if(messageCount < boxContent.dialogies[i].Length)
            {
                if(Input.GetKeyUp(KeyCode.Mouse0))
                {
                    txtbox.currentMessage = GenerateMessages(boxContent.dialogies[i], messageCount);
                    messageCount++;
                }
            }
            else
            {
                txtbox.showBox = false;
                txtbox.showMessage = false;
                txtbox.currentMessage = "";
                messageCount = 0;
            }
        }
    }

    private string GenerateMessages(string[] messageArray, int messageID)
    {
        txtbox.currentMessage += messageArray[messageID];

        return txtbox.currentMessage;
    }
}