using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldController : MonoBehaviour
{
    public static WorldController instance = null;

    int currentSceneIndex;
    int worldUnlocked;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        worldUnlocked = PlayerPrefs.GetInt("WorldUnlocked");

        if (instance != null)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
        }
    }

    public void UnlockNextWorld()
    {    
            if (currentSceneIndex == 7)
                Invoke("LoadMainMenu", 1f);
            else
            {
                if (worldUnlocked < currentSceneIndex)
                    PlayerPrefs.SetInt("WorldUnlocked", currentSceneIndex);
                    Invoke("UnlockNext", 0.5f);
            }
    }

    void UnlockNext()
    {
        SceneManager.LoadScene(2);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
