using UnityEngine;
using System.Collections;

public class CheckMousePos : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.mousePosition == col.gameObject.transform.position)
        {

            Debug.Log(mousePos + col.gameObject.name);
        }
        else
            Debug.Log("nottin");

    }
}
