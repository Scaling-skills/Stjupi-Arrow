using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour 

{
public AudioSource AppleBite;
     private void OnCollisionEnter2D(Collision2D other) 
    {
        AppleBite = GetComponent<AudioSource> ();
        Destroy(other.gameObject);
        Score.scoreValue += 1;
        AppleBite.Play();
    }
}
 