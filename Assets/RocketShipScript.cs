using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShipScript : MonoBehaviour
{
    public GameObject[] bubbles;
    public GameObject healthBar1;
    public GameObject healthBar2;
    public GameObject healthBar3;
    public int healthCount = 3;
    public LogicScript logic;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        bubbles = GameObject.FindGameObjectsWithTag("bubble");
        GameObject asteroid = GameObject.FindWithTag("asteroid");
        DeleteHealth();
        Destroy(asteroid);
        foreach (GameObject a in bubbles) { Destroy(a); }
    }

    public void DeleteHealth()
    {
        logic = GameObject.FindWithTag("logic").GetComponent<LogicScript>();
        switch(healthCount)
        {
            case 3:
                Destroy(healthBar3);
                --healthCount;
                break;
            case 2:
                Destroy(healthBar2);
                --healthCount;
                break;
            case 1:
                Destroy(healthBar1);
                --healthCount;
                break;
        }
        logic.AddHit();
    }
}
