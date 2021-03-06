﻿using UnityEngine;
using System.Collections;

public class HandleMessages : MonoBehaviour
{
    public GUISkin skin;
    private TextBox txtbox;
    private TextBoxContent boxContent;
    private Options option;
    public bool showOptions;
    private bool oneTime;
    public string[] sceneNames;
    public int messageCount;
    public bool lastLine;
    public string firstLine;
    public float boxLMultiplier = 2.37037f;
    public float boxTMultiplier = 4.8f;
    public float boxWMultiplier = 2f;
    public float boxHMultiplier = 4f;

	// Use this for initialization
	private void Start ()
    {
        txtbox = GetComponent<TextBox>();
        option = GetComponent<Options>();
        txtbox.currentMessage = firstLine;
        boxContent = GetComponent<TextBoxContent>();
        messageCount = 0;
        lastLine = false;

        sceneNames = new string[6];
        sceneNames[0] = "scene1";
        sceneNames[1] = "scene2";
        sceneNames[2] = "scene3";
        sceneNames[3] = "scene4";
        sceneNames[4] = "scene5";
        sceneNames[5] = "end";

        showOptions = false;
        oneTime = false;
	}

    private void Update()
    {
        if(!oneTime && showOptions)
        {
            option.DrawOptions();
            oneTime = true;
        }
    }

    private void OnGUI()
    {
        GUI.skin = skin;
        if (lastLine)
        {
            //if (GUI.Button(new Rect(Screen.width / boxLMultiplier, Screen.height / boxTMultiplier, Screen.width / boxWMultiplier, Screen.height / boxHMultiplier), "Seuraava sivu", skin.GetStyle("buttontest")))
            //{
            //    ChangeScene();
            //}
            //option.DrawOptions();
        }
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
            lastLine = true;
            showOptions = true;
            if(Application.loadedLevel == 5)
            {
                Application.LoadLevel(0);
            }
        }
    }

    private string GenerateMessages(string[] messageArray, int messageID)
    {
        txtbox.currentMessage = messageArray[messageID];

        return txtbox.currentMessage;
    }

    public void ChangeScene()
    {
        for (int i = 0; i < sceneNames.Length; i++)
        {
            if (Application.loadedLevelName == sceneNames[i])
                Application.LoadLevel(sceneNames[i + 1]);

            if (Application.loadedLevelName == sceneNames[5])
                break;
        }
    }
}