using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour
{
    public GameObject[] options;
    public GameObject buttonPrefab;
    public Sprite[] optionImages;
    public GameObject soundIcon;
    public Sprite sIcon;
    private GameObject bunnygo;
    public GameObject bunnyPrefab;
    public Sprite[] bunny;
    public AudioClip[] optionSoundClips;
    private int optionCount = 3;
    private float offset = 0;
    private bool isButtonPressed;
    private bool isPressedTwice;
    private bool touched;
    private HandleMessages handler;
    private float osx, osy = 0;

	// Use this for initialization
	private void Start ()
    {
        handler = GetComponent<HandleMessages>();
        options = new GameObject[3];
        optionSoundClips = new AudioClip[3];
        isButtonPressed = false;
        touched = false;
	}
	
	// Update is called once per frame
	private void Update ()
    {
        CheckIfTouched();
        Debug.Log(isButtonPressed);
	}

    public void DrawOptions()
    {
        if(handler.showOptions)
        {
            options[0] = (GameObject)Instantiate(buttonPrefab, new Vector3(-4.9f, 2.19f), Quaternion.identity);
            options[0].GetComponent<SpriteRenderer>().sprite = optionImages[0];

            options[1] = (GameObject)Instantiate(buttonPrefab, new Vector3(-4.9f, -2.7f), Quaternion.identity);
            options[1].GetComponent<SpriteRenderer>().sprite = optionImages[1];

            options[2] = (GameObject)Instantiate(buttonPrefab, new Vector3(1.5f, 0), Quaternion.identity);
            options[2].GetComponent<SpriteRenderer>().sprite = optionImages[2];

            bunnygo = (GameObject)Instantiate(bunnyPrefab, new Vector3(6.8f, -1.3f), Quaternion.identity);
            bunnygo.GetComponent<SpriteRenderer>().sprite = bunny[0];
        }
    }

    private void CheckIfTouched()
    {
        if(handler.showOptions)
        {
            if (Input.GetMouseButtonUp(0) && !isButtonPressed)
            {
                isButtonPressed = true;
                for (int i = 0; i < 3; i++)
                {
                    if (Vector2.Distance(options[i].transform.localPosition, Camera.main.ScreenToWorldPoint(Input.mousePosition)) < 2)
                    {
                        Debug.DrawLine(options[i].transform.localPosition, Camera.main.ScreenToWorldPoint(Input.mousePosition), Color.red, 2f);

                        if (i < 2)
                        {
                            osy -= 4.51f;
                            //wrong
                            soundIcon = (GameObject)Instantiate(buttonPrefab, new Vector3(1f, 1.34f + osy), Quaternion.identity);
                            soundIcon.GetComponent<SpriteRenderer>().sprite = sIcon;
                            if (Vector2.Distance(soundIcon.transform.localPosition, Camera.main.ScreenToWorldPoint(Input.mousePosition)) < 1)
                            {
                                Debug.Log("wrong");
                                bunnygo.GetComponent<SpriteRenderer>().sprite = bunny[1];
                                Invoke("ChangeToNormalBunny", 1.4f);
                            }
                        }
                        if (i == 2)
                        {
                            osx += 5.4f;
                            //right
                            soundIcon = (GameObject)Instantiate(buttonPrefab, new Vector3(2 + osx, 2.19f), Quaternion.identity);
                            soundIcon.GetComponent<SpriteRenderer>().sprite = sIcon;
                            if (Vector2.Distance(soundIcon.transform.localPosition, Camera.main.ScreenToWorldPoint(Input.mousePosition)) < 1)
                            {
                                Debug.Log("right");
                                bunnygo.GetComponent<SpriteRenderer>().sprite = bunny[2];
                                Invoke("SceneChanger", 1.5f);
                            }
                        }
                    }
                    else
                        isButtonPressed = false;
                }
            }
        }
    }

    private void ChangeToNormalBunny()
    {
        bunnygo.GetComponent<SpriteRenderer>().sprite = bunny[0];
    }

    private void SceneChanger()
    {
        handler.ChangeScene();
    }
}