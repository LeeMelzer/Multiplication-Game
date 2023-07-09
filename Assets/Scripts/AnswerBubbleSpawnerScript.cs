using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerBubbleSpawnerScript : MonoBehaviour
{
    public GameObject answerBubble;
    public GameObject incorrectAnswerBubble;

    public void SpawnCorrect()
    {
        Instantiate(answerBubble, transform.position, transform.rotation);
        
    }

    public void SpawnIncorrect()
    {
        Instantiate(incorrectAnswerBubble, transform.position, transform.rotation);
    }
}
