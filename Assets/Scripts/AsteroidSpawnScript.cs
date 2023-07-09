using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class AsteroidSpawnScript : MonoBehaviour
{
    public GameObject asteroid;

    public void Spawn()
    {
        Instantiate(asteroid, transform.position, transform.rotation);
    }
}
