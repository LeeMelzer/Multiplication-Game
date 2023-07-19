using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class asteroidScript : MonoBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float moveSpeed;
    public string problem;
    public Text textElement;
    public GameObject explosion;

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

    public void Explode()
    {
        AudioManager.instance.Play("Explosion");
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
