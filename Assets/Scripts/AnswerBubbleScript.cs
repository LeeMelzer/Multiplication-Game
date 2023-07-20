using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBubbleScript : MonoBehaviour
{
    public Text textElement;
    public string number;
    public GameObject[] bubbles;
    public LogicScript logic;
    public asteroidScript asteroidScript;

    // Update is called once per frame
    void Update()
    {
        textElement.text = number;
    }

    public void SetNumber(string number)
    {
        this.number = number; 
    }

    // Onclick method to delete asteroid and other answer bubbles
    private void OnMouseDown()
    {
        GameObject asteroid = GameObject.FindWithTag("asteroid");
        asteroidScript = GameObject.FindGameObjectWithTag("asteroid").GetComponent<asteroidScript>();
        bubbles = GameObject.FindGameObjectsWithTag("bubble");
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        if (AsteroidSpawnScript.hard == true) { logic.AddScore(); }
        asteroidScript.Explode(); 
        Destroy(asteroid);
        foreach (GameObject a in bubbles) { Destroy(a); }
    }
}
