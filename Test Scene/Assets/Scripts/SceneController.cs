using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    private int currentSceneIndex;

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadNextScene()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadCharacterSelection()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadWorldSelectionScreen()
    {
        SceneManager.LoadScene(2);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
