﻿using System.Collections;
using UnityEngine;

public class RockController : MonoBehaviour
{

    float fallSpeed;
    float rotspeed;

    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
        this.rotspeed = 5f + 3f * Random.value;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( 0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotspeed);

        if(transform.position.y < -5.5f){
            Destroy(gameObject);
        }
        
    }
}
