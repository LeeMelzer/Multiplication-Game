using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBubbleScript : MonoBehaviour
{
    public Text textElement;
    public string number;
    public GameObject[] bubbles; // I know that girl!

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        bubbles = GameObject.FindGameObjectsWithTag("bubble");
        Destroy(asteroid); 
        foreach (GameObject a in bubbles) { Destroy(a); }
        //Destroy(gameObject);
    }

}
