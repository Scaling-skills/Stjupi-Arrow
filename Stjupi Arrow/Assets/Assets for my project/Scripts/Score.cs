using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    
    void Start()
    {
        score = GetComponent<Text> ();
    }

    
    void Update()
    {
        score.text = "" + scoreValue;
        if(scoreValue==10)
        {   
            transform.position = new Vector2(10,10);
        }
    }

      
}
