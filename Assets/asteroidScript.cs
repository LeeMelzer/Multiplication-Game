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
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        textElement.text = problem;
    }

    public void SetProblem(string problem)
    {
        this.problem = problem;
    }



}
