using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class AsteroidSpawnScript : MonoBehaviour
{
    public GameObject asteroid;
    public int answer = 24;
    public bool spawn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            Instantiate(asteroid, transform.position, transform.rotation);
            spawn = false;
        }
    }

    public void Spawn()
    {
        spawn = true;
    }
}
