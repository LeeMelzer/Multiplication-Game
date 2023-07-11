using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class AsteroidSpawnScript : MonoBehaviour
{
    public GameObject asteroidEasy;
    public GameObject asteroidMedium;
    public GameObject asteroidHard;
    public static bool easy = false;
    public static bool medium = false;
    public static bool hard = false;

    public void Spawn()
    {
        if (easy)
        {
            Instantiate(asteroidEasy, transform.position, transform.rotation);
        }
        else if (medium)
        {
            Instantiate(asteroidMedium, transform.position, transform.rotation);
        }
        else if (hard)
        {
            Instantiate(asteroidHard, transform.position, transform.rotation);
        }
    }
}
