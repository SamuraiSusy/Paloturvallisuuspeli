using UnityEngine;
using System.Collections;

public class HandleMessages : MonoBehaviour
{
    private TextBox txtbox;
    private TextBoxContent boxContent;
    public string[] curBoxContent;
    public int messageCount;

	// Use this for initialization
	private void Start ()
    {
        txtbox = GetComponent<TextBox>();
        boxContent = GetComponent<TextBoxContent>();
	}

    public void ChangeMessages(int sceneID)
    {
        WriteMessages(sceneID);
    }

    private void WriteMessages(int dialogueID)
    {
        if (messageCount < boxContent.dialogies[dialogueID].Length)
        {
            if(Input.GetKeyUp(KeyCode.Mouse0))
            {
                Debug.Log("pressed mouse 0");
                txtbox.currentMessage = GenerateMessages(boxContent.dialogies[dialogueID], messageCount);
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

    private string GenerateMessages(string[] messageArray, int messageID)
    {
        txtbox.currentMessage += messageArray[messageID];

        return txtbox.currentMessage;
    }
}