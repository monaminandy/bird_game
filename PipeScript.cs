using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float movespeed = 5;
    private float deadzone = -43;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
    }
}
