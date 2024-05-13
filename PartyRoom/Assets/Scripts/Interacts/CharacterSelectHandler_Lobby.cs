using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectHandler_Lobby : MonoBehaviour
{
    public GameObject[] characters;
    public GameObject activeSelect;

    public GameObject selectPanel;
    public GameObject playerSet;

    private PlayerData playerData;
    private Animator selectPanelAnim;
    private Button[] playerButtons;

    void Start()
    {
        playerData = GameManager.instance.savePlayerData;
        playerButtons = new Button[characters.Length];
        selectPanelAnim = selectPanel.GetComponent<Animator>();

        for (int i = 0; i < characters.Length; i++)
        {
            playerButtons[i] = characters[i].GetComponent<Button>();
            playerButtons[i].interactable = false;

            if (playerButtons[i] == null)
            {
                Debug.LogError($"characters[{i}]에 버튼 컴포넌트가 없음.");
            }
        }
    }

    public void OnSelectClicked()
    {
        selectPanel.SetActive(true);
        playerSet.SetActive(true);
        selectPanelAnim.SetBool("IsClicked", true);

        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].GetComponent<Animator>().SetBool("IsClicked", true);
            playerButtons[i].interactable = true;
            Debug.Log(i);
        }
    }

    public void OnChoosePlayer(GameObject selectedPlayer)
    {
        selectPanelAnim.SetBool("IsClicked", false);
        
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].GetComponent<Animator>().SetBool("IsClicked", false);
            playerButtons[i].interactable = false;
        }

        //애니메이션과 연결할 폴더 이름 변경
        playerData.characterChangePath = selectedPlayer.name;
        Debug.Log(playerData.characterChangePath);
        playerSet.SetActive(false);
        selectPanel.SetActive(false);
    }
}
