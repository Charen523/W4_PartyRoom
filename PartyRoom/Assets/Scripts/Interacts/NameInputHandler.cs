using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInputHandler : MonoBehaviour
{
    public GameObject nameInput;

    public void SetPlayerName()
    {
        InputField nameInputField = nameInput.GetComponent<InputField>();
        
    if (nameInputField == null)
        {
            Debug.LogError("nameInputField�� NameInputHandler�� �ν����Ϳ� �Ҵ���� ����!");
        }
        else
        {
            GameManager.instance.savePlayerData.characterName = nameInputField.text;
        }
    }
}
