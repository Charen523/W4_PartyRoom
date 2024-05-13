using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCTriggerHandler : MonoBehaviour 
{
    [SerializeField] private PlayerData npcData;
    public Transform npcTransform;
    public GameObject interactionPanel;
    public GameObject speakPanel;

    private Vector3 interactPanelOffset = new Vector3(2, 0, 0);
    private Vector3 speakPanelOffset = new Vector3(2, 2, 0);


    // Start is called before the first frame update
    void Start()
    {
        interactionPanel.SetActive(false);
        speakPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePanelPosition();
    }

    void UpdatePanelPosition()
    {
        // �г��� ��ġ�� NPC ��ġ �������� �������� �����Ͽ� ����
        interactionPanel.transform.position  = GameManager.instance.currentPlayer.GetComponent<Transform>().position + interactPanelOffset;
        speakPanel.transform.position = npcTransform.position + speakPanelOffset;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactionPanel.SetActive(true); // NPC �г��� Ȱ��ȭ
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            interactionPanel.SetActive(false);
    }
}
