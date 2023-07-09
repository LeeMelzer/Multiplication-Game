using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncorrectAnswerBubbleScript : MonoBehaviour
{
    public Text textElement;
    public string number;
    public LogicScript logic;
    public GameObject[] bubbles;

    // Update is called once per frame
    void Update()
    {
        textElement.text = number;
    }

    public void SetNumber(string number)
    {
        this.number = number;
    }

    // Onclick method to delete answer bubble
    private void OnMouseDown()
    {
        logic = GameObject.FindWithTag("logic").GetComponent<LogicScript>();
        bubbles = GameObject.FindGameObjectsWithTag("bubble");
        foreach (GameObject b in bubbles) { Destroy(b); }
        logic.DisplayAnswer();
    }
}
