using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawning : MonoBehaviour
{
    public GameObject spawning;
    public float rate = 2;
    private float timer = 0;
    public float height = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < rate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
        }
    }
    void spawn()
    {
        float lower = transform.position.y - height;
        float upper = transform.position.y + height;
        Instantiate(spawning, new Vector3(transform.position.x, Random.Range(lower,upper),0), transform.rotation);
    }
}
