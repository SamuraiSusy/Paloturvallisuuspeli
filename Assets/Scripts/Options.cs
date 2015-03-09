using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour
{
    public GameObject[] options;
    public GameObject buttonPrefab;
    public Sprite[] optionImages = new Sprite[3];
    private GameObject bunnygo;
    public GameObject bunnyPrefab;
    public Sprite[] bunny = new Sprite[3];
    public AudioClip[] optionSoundClips;
    private int optionCount = 3;
    private float offset = 0;
    private bool isButtonPressed;
    private bool touched;
    private HandleMessages handler;

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
            for (int i = 0; i < 3; ++i)
            {
                if (i < 2)
                {
                    options[i] = (GameObject)Instantiate(buttonPrefab, new Vector3(-6 + offset, 2), Quaternion.identity);
                    offset += 5f;
                    options[i].GetComponent<SpriteRenderer>().sprite = optionImages[i];
                }
                else if (i == 2)
                {
                    options[i] = (GameObject)Instantiate(buttonPrefab, new Vector3(-3.4f, -2.3f), Quaternion.identity);
                    options[i].GetComponent<SpriteRenderer>().sprite = optionImages[i];
                }
            }
            bunnygo = (GameObject)Instantiate(bunnyPrefab, new Vector3(7, -1), Quaternion.identity);
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
                        Debug.Log("hi");

                        if(i < 2)
                        {
                            //wrong
                            Debug.Log("wrong");
                            bunnygo.GetComponent<SpriteRenderer>().sprite = bunny[1];
                        }
                        if(i == 2)
                        {
                            //right
                            Debug.Log("right");
                            bunnygo.GetComponent<SpriteRenderer>().sprite = bunny[2];
                            Invoke("SceneChanger", 1.5f);
                        }
                    }
                    else
                        isButtonPressed = false;
                }
            }
        }
    }

    private void SceneChanger()
    {
        handler.ChangeScene();
    }
}