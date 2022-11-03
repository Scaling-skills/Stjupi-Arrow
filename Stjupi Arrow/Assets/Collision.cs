using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour 
{
    private void OnTriggerEnter2D(Collider2D collider2d) 
             
    {
        Debug.Log ("Target down");
    }
    
}
