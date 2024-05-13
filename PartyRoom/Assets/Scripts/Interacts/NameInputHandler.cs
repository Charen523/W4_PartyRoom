using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInputHandler : MonoBehaviour
{
    public GameObject nameInput;
    public PlayerDataHandler playerStatHandler;

    public void SetPlayerName()
    {
        InputField nameInputField = nameInput.GetComponent<InputField>();

        if (playerStatHandler == null)
        {
            Debug.LogError("PlayerStatHandler가 NameInputHandler의 인스펙터에 할당되지 않음!");
        }
        else if (nameInputField == null)
        {
            Debug.LogError("nameInputField가 NameInputHandler의 인스펙터에 할당되지 않음!");
        }
        else
        {
            playerStatHandler.setCharacterName(nameInputField.text);
        }
    }
}
