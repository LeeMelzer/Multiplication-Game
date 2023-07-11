using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnEasyButton()
    {
        AsteroidSpawnScript.easy = true;
        SceneManager.LoadScene(1);
    }

    public void OnMediumButton()
    {
        AsteroidSpawnScript.medium = true;
        SceneManager.LoadScene(1);
    }

    public void OnHardButton()
    { 
        AsteroidSpawnScript.hard = true;
        SceneManager.LoadScene(1);
    }
}
