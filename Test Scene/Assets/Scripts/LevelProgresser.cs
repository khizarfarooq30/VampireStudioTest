using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProgresser : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var coinsCount = GameObject.FindGameObjectsWithTag("Coins");

        if (collision.tag == "Player" && coinsCount.Length == 0){
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            FindObjectOfType<WorldController>().UnlockNextWorld();
        } else
        {
            FindObjectOfType<SceneController>().GameOver();
        }
    }
}
