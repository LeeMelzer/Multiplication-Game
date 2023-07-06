using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBubbleScript : MonoBehaviour
{
    public Text textElement;
    public string number;
    public GameObject asteroid;
    

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

    // Onclick method

    
}
