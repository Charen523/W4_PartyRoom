using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectHandler : MonoBehaviour
{
    public GameObject[] characters;
    public GameObject activeSelect;

    public Animator selectPanelAnim;

    private GameObject player;
    private Button[] playerButtons;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.instance.currentPlayer;
        playerButtons = new Button[characters.Length];

        for(int i = 0; i < characters.Length; i++)
        {
            playerButtons[i] = characters[i].GetComponent<Button>();
            playerButtons[i].interactable = false;

            if (playerButtons[i] == null)
            {
                Debug.LogError($"characters[{i}]�� ��ư ������Ʈ�� ����.");
            }
        }
    }

    public void OnSelectClicked()
    {
        selectPanelAnim.SetBool("IsClicked", true);
        activeSelect.SetActive(false);

        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].GetComponent<Animator>().SetBool("IsClicked", true);
            playerButtons[i].interactable = true;
        }
    }

    public void OnChoosePlayer(GameObject selectedPlayer)
    {
        selectPanelAnim.SetBool("IsClicked", false);
        activeSelect.SetActive(true);

        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].GetComponent<Animator>().SetBool("IsClicked", false);
            playerButtons[i].interactable = false;
        }

        selectedPlayer.transform.SetAsLastSibling();

        //�ִϸ��̼ǰ� ������ ���� �̸� ����
        player.GetComponent<PlayerDataHandler>().setCharacterImage(selectedPlayer.name);
    }
}
