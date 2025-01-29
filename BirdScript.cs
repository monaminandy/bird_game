using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidbody1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            rigidbody1.velocity = Vector2.up * 10;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            rigidbody1.velocity = Vector2.down * 10;
        }
    }
}
