using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Soban_exit : MonoBehaviour
{
    // 소반 UI control용 - exit 구현
    public bool bool_isSoban_exit = false;

    public GameObject images;

    /*
    public void OnPointerDown(PointerEventData eventData)
    {
        //Down Event
        Debug.Log("Touch! Soban!!!!");
    }
    */
    public void Update()
    {


    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bool_isSoban_exit = true;
            if (bool_isSoban_exit == true)
            {
                images.SetActive(false);
                bool_isSoban_exit = false;
                //images.SetActive(false);
            }
        }
    }
}
