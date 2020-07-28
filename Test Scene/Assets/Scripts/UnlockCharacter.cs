using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockCharacter : MonoBehaviour
{
    public Button[] button;
    int worldUnlocked;
    public int buttonIndex;
    

    private void Start()
    {
        button[buttonIndex + 1].interactable = false;
        button[buttonIndex + 2].interactable = false;
        button[buttonIndex + 3].interactable = false;
        worldUnlocked = PlayerPrefs.GetInt("WorldUnlocked", worldUnlocked);
        CheckWorldUnlocked();
    }

    private void CheckWorldUnlocked()
    {
        switch (worldUnlocked)
        {
            case 3:
                button[buttonIndex + 1].interactable = true;
              
                break;
            case 4:
                button[buttonIndex + 1].interactable = true;
                button[buttonIndex + 2].interactable = true;
                break;
            case 5:
                button[buttonIndex + 1].interactable = true;
                button[buttonIndex + 2].interactable = true;
                button[buttonIndex + 3].interactable = true;
                break;
        }
    }

    public void LockAllCharacters()
    {
        FindObjectOfType<CharacterSelection>().characterIndex = 0;
        button[buttonIndex + 1].interactable = false;
        button[buttonIndex + 2].interactable = false;
        button[buttonIndex + 3].interactable = false;
        PlayerPrefs.DeleteAll();
    }

}
