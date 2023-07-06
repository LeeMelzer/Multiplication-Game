using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerBubbleSpawnerScript : MonoBehaviour
{
    public GameObject answerBubble;
    public bool spawn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            Instantiate(answerBubble, transform.position, transform.rotation);
            spawn = false;
        }
    }

    public void Spawn()
    {
        Instantiate(answerBubble, transform.position, transform.rotation);
        //spawn = true;
    }
}
