using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

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

    public void SwitchCharacters()
    {
        Destroy(currentCharacter, 0f);
        currentCharacter = Instantiate(selectableCharacters[characterIndex].character, transform.position, transform.rotation, transform);
    }

    public void BlueMan()
    {

        characterIndex = 0;

        SwitchCharacters();
    }

    public void GreenMan()
    {

        characterIndex = 1;

        SwitchCharacters();
    }

    public void RedMan()
    {

        characterIndex = 2;

        SwitchCharacters();
    }

    public void WhiteMan()
    {

        characterIndex = 3;

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
