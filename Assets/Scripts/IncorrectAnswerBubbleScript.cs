using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncorrectAnswerBubbleScript : MonoBehaviour
{
    public Text textElement;
    public string number;

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

    // Onclick method to delete answer bubble
    private void OnMouseDown()
    {
        Destroy(gameObject); 
    }
}
