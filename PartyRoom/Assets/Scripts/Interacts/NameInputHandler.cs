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
            Debug.LogError("PlayerStatHandler�� NameInputHandler�� �ν����Ϳ� �Ҵ���� ����!");
        }
        else if (nameInputField == null)
        {
            Debug.LogError("nameInputField�� NameInputHandler�� �ν����Ϳ� �Ҵ���� ����!");
        }
        else
        {
            playerStatHandler.setCharacterName(nameInputField.text);
        }
    }
}
