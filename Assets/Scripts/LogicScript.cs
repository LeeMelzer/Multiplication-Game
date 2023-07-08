using System.Threading.Tasks;
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
    public IncorrectAnswerBubbleScript incorrectAnswerBubble;
    public string problem;
    public string answer; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("asteroid") == null)
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
                // need to check that generated answers do not equal the correct answer -- no duplicates
                case 1:
                    answerBubbleSpawner1.SpawnCorrect();
                    incorrectAnswerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner2.SpawnIncorrect();
                    incorrectAnswerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner3.SpawnIncorrect();
                    break;
                case 2:
                    answerBubbleSpawner2.SpawnCorrect();
                    incorrectAnswerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner1.SpawnIncorrect();
                    incorrectAnswerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner3.SpawnIncorrect();
                    break;
                case 3:
                    answerBubbleSpawner3.SpawnCorrect();
                    incorrectAnswerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner2.SpawnIncorrect();
                    incorrectAnswerBubble.SetNumber(GenerateIncorrectAnswer());
                    answerBubbleSpawner1.SpawnIncorrect();
                    break;
            }
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
}
