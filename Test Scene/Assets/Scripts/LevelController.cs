using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    int worldUnlocked;
    public Button forest, road, beach, snow;

    // Start is called before the first frame update
    void Start()
    {
        worldUnlocked = PlayerPrefs.GetInt("WorldUnlocked");
        forest.interactable = false;
        road.interactable = false;
        beach.interactable = false;
        snow.interactable = false;

        CheckWorldUnlocked();
    }

    private void CheckWorldUnlocked()
    {
        switch (worldUnlocked)
        {
            case 1:
                forest.interactable = true;
                break;
            case 2:
                forest.interactable = true;
                road.interactable = true;
                break;
            case 3:
                forest.interactable = true;
                road.interactable = true;
                beach.interactable = true;
                break;
            case 4:
                forest.interactable = true;
                road.interactable = true;
                beach.interactable = true;
                snow.interactable = true;
                break;
        }
    }

   public void LoadNextWorld(String world)
    {
        SceneManager.LoadScene(world);
    }
 
}
