using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource boomSFX;
    
    

    [ContextMenu("Increase Score")]
        public void addScore(int scoreAdded)
    {
        playerScore = playerScore + scoreAdded;
        scoreText.text = playerScore.ToString();
        boomSFX.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        
    }
}

