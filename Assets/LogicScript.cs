using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public AsteroidSpawnScript asteroidSpawner1;
    public AsteroidSpawnScript asteroidSpawner2;
    public AsteroidSpawnScript asteroidSpawner3;
    public AsteroidSpawnScript asteroidSpawner4;
    public AsteroidSpawnScript asteroidSpawner5;
    public AsteroidSpawnScript asteroidSpawner6;
    public AnswerBubbleSpawnerScript answerBubbleSpawner1;
    public AnswerBubbleSpawnerScript answerBubbleSpawner2;
    public AnswerBubbleSpawnerScript answerBubbleSpawner3;
    public asteroidScript asteroid;
    public AnswerBubbleScript answerBubble; 
    public bool asteroidExists = false;
    public string problem;
    public string answer; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!asteroidExists)
        {
            // Generate problems and answers here
            CreateProblem(); 
            asteroid.SetProblem(problem);
            answerBubble.SetNumber(answer); 

            // Randomly select asteroid spawner and spawn
            int selectSpawner = Random.Range(1, 7);

            switch (selectSpawner)
            {
                case 1:
                    asteroidSpawner1.Spawn();
                    break;
                case 2:
                    asteroidSpawner2.Spawn();
                    break;
                case 3:
                    asteroidSpawner3.Spawn();
                    break;
                case 4:
                    asteroidSpawner4.Spawn();
                    break;
                case 5:
                    asteroidSpawner5.Spawn();
                    break;
                case 6:
                    asteroidSpawner6.Spawn();
                    break;
            }

            // Spawn the answer bubbles here
            int selectBubble = Random.Range(1, 4);
            switch (selectBubble)
            {
                case 1:
                    answerBubbleSpawner1.Spawn();
                    answerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner2.Spawn();
                    answerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner3.Spawn();
                    break;
                case 2:
                    answerBubbleSpawner2.Spawn();
                    answerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner1.Spawn();
                    answerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner3.Spawn();
                    break;
                case 3:
                    answerBubbleSpawner3.Spawn();
                    answerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner2.Spawn();
                    answerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner1.Spawn();
                    break;
            }

            // Halt asteroid spawning until asteroid is destroyed
            asteroidExists = true;
        }
    }

    // Functions to generate problems and answers
    public void CreateProblem()
    {
        int firstNumber = Random.Range(2, 13);
        int secondNumber = Random.Range(2, 13);
        int temp = firstNumber * secondNumber;
        problem = firstNumber.ToString() + " X " + secondNumber.ToString();
        answer = temp.ToString(); 
    }

    public string GenerateIncorrectAnswer()
    {
        int firstNumber = Random.Range(2, 13);
        int secondNumber = Random.Range(2, 13);
        return (firstNumber * secondNumber).ToString();
    }

    // Function to trigger new asteroid spawn
    public void AsteroidDestroyed()
    {
        asteroidExists = false;
    }

}
