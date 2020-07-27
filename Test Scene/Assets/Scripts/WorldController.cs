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
        if(instance != null)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        worldUnlocked = PlayerPrefs.GetInt("WorldUnlocked");
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void UnlockNextWorld()
    {
        if(worldUnlocked < currentSceneIndex)
        {
            PlayerPrefs.SetInt("WorldUnlocked", worldUnlocked);
            FindObjectOfType<LevelController>().LoadNextWorld(currentSceneIndex + 1);
        }
    }
}
