using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveLeft : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
   bool isPressed = false;
   public GameObject Player;
   public float Force;

    // Update is called once per frame
    void Update()
    {
        if(isPressed)
        {
            Player.transform.Translate(Force * Time.deltatime, 0, 0);
        }
    }

    pulbic Void OnPointerDown(PointerEventData event Data)
    {
        isPressed = true;
    }

     pulbic Void OnPointerUp(PointerEventData event Data)
    {
        isPressed = false;
    }




}
