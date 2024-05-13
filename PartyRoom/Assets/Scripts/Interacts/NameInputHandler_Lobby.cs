using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameInputHandler_Lobby : MonoBehaviour
{
    public GameObject nameInput;
    public GameObject nameBoard;

    public void OnChangeClicked()
    {
        nameBoard.SetActive(true);
        nameInput.SetActive(true);
    }

    public void SetPlayerName()
    {
        InputField nameInputField = nameInput.GetComponent<InputField>();

        if (nameInputField == null)
        {
            Debug.LogError("nameInputField가 NameInputHandler의 인스펙터에 할당되지 않음!");
        }
        else
        {
            GameManager.instance.savePlayerData.characterName = nameInputField.text;
            Debug.Log(nameInputField.text);
        }

        nameInput.SetActive(false);
        nameBoard.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
