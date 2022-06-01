using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverPanel;
    public GameObject taptostart;
    public GameObject scoretext;
    public void Start()
    {
        taptostart.SetActive(true);
        PauseGame();
        scoretext.SetActive(false);
        gameOverPanel.SetActive(false); 
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startGame();
        }
    }
    public void GameOver()
    {
        scoretext.SetActive(false);
        gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void startGame()
    {
        Time.timeScale=1f;
        scoretext.SetActive(true);
        taptostart.SetActive(false);
    }
}
