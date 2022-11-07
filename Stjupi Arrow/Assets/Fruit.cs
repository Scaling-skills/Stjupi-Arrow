using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector3 screenBounds;


    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(0, -speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
