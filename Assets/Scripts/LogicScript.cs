using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public GameObject rocketShip;
    public GameObject gameOverScreen;
    public Text answerBox;
    public string problem;
    public int answer;
    public int userScore;
    public Text scoreText;
    public int hits = 0;
    public HashSet<int> set = new HashSet<int>(); 

    // Update is called once per frame
    void Update()
    {
        // Counter for collisions and game over condition
        if (hits > 2)
        {
            Destroy(rocketShip);
            GameOver();
        }
        
        // greater than two hits = game over
        if (GameObject.FindWithTag("asteroid") == null && hits <= 2)
        {
            // Clear the answer box of previous answer
            answerBox.text = "";

            // Clear the hashset for new round of answers
            set.Clear();

            // Generate problems and answers here
            CreateProblem();
            asteroid.SetProblem(problem);
            answerBubble.SetNumber(answer.ToString());

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
        answer = temp;
        set.Add(answer);
    }

    public string GenerateIncorrectAnswer()
    {
        int temp;
        do
        {
            int firstNumber = Random.Range(2, 13);
            int secondNumber = Random.Range(2, 13);
            temp = firstNumber * secondNumber;
        } while (set.Contains(temp));
        set.Add(temp);
        return temp.ToString();
    }    

    public void AddScore()
    {
        userScore += 100;
        scoreText.text = userScore.ToString();
    }

    public void AddHit()
    {
        ++hits;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        answerBox.text = "";
        gameOverScreen.SetActive(true);
    }

    public void DisplayAnswer()
    {
        answerBox.text = answer.ToString();
    }
}
