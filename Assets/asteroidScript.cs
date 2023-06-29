using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class asteroidScript : MonoBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float moveSpeed = 1;
    public string problem;
    public Text textElement;

    // Start is called before the first frame update
    void Start()
    {
        DisplayProblem();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        textElement.text = problem;
    }

    public int GenerateNumber()
    {
        return Random.Range(2, 13); 
    }

    public void DisplayProblem()
    {
        int firstNumber = GenerateNumber();
        int secondNumber = GenerateNumber();
        problem = firstNumber.ToString() + " X " + secondNumber.ToString();
    }


}
