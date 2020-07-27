using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public CharacterSelector[] selectableCharacters;

    private GameObject currentCharacter;
    public int characterIndex;

    private void Awake()
    {
        characterIndex = PlayerPrefs.GetInt("characterIndex", characterIndex);
    }

    private void Start()
    {
        SwitchCharacters();
    }

    private void SwitchCharacters()
    {
        Destroy(currentCharacter, 0f);
        currentCharacter = Instantiate(selectableCharacters[characterIndex].character, transform.position, transform.rotation, transform);
    }

    public void LeftButton()
    {
        characterIndex--;
        if(characterIndex < 0)
        {
            characterIndex = selectableCharacters.Length - 1;
        }
        SwitchCharacters();
    }

    public void RightButton()
    {
        characterIndex++;
        if (characterIndex == selectableCharacters.Length)
        {
            characterIndex = 0;
        }
        SwitchCharacters();
    }

    public void Play()
    {
        PlayerPrefs.SetInt("characterIndex", characterIndex);
        FindObjectOfType<SceneController>().LoadNextScene();
    }

    [System.Serializable]
    public class CharacterSelector
    {
        public GameObject character;
    }
}
