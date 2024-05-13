using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticipantListText : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject SidePanel;
    public Text participant;

    private Animator sideAnim;

    void Start()
    {
         sideAnim = GetComponent<Animator>();

        GameObject[] NPCList = GameObject.FindGameObjectsWithTag("NPC");

        string playerName = GameManager.instance.savePlayerData.characterName;
        participant.text += (playerName + "\n");

        foreach (GameObject NPC in NPCList)
        {
            string name = NPC.GetComponent<NPCDataHandler>().GetNPCName();

            participant.text += (name + "\n");
        }
    }

    public void OnSidePanelClick()
    {
        if (sideAnim.GetBool("IsClicked"))
        {
            sideAnim.SetBool("IsClicked", false);
        }
        else
        {
            sideAnim.SetBool("IsClicked", true);
        }
    }
}
