using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerBubbleSpawnerScript : MonoBehaviour
{
    public GameObject answerBubble;
    public GameObject incorrectAnswerBubble;
    public bool spawn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnCorrect()
    {
        Instantiate(answerBubble, transform.position, transform.rotation);
        
    }

    public void SpawnIncorrect()
    {
        Instantiate(incorrectAnswerBubble, transform.position, transform.rotation);
    }
}
