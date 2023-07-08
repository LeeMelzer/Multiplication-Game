using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShipScript : MonoBehaviour
{
    public GameObject[] bubbles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        bubbles = GameObject.FindGameObjectsWithTag("bubble");
        GameObject asteroid = GameObject.FindWithTag("asteroid");
        Destroy(asteroid);
        foreach (GameObject a in bubbles) { Destroy(a); }
        // add delete healthbar functionality
    }
}
