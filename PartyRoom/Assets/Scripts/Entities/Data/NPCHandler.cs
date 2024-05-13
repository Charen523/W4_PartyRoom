//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;

//public class NPCHandler : MonoBehaviour
//{
//    [SerializeField] private PlayerData npcData;
//    public Transform npcTransform;
//    public GameObject interactionPanel;
//    public Vector3 panelOffset = new Vector3(1, 1, 0);


//    // Start is called before the first frame update
//    void Start()
//    {
//        interactionPanel.SetActive(false);
//    }

//    // Update is called once per frame
//    void Update()
//    {


//        if (Vector3.Distance(Player.instance.transform.position, npcTransform.position) < 5f)  // 예: 5 유닛 거리 내에 있을 때
//        {
//            interactionPanel.SetActive(true);
//            UpdatePanelPosition();
//        }
//        else
//        {
//            interactionPanel.SetActive(false);
//        }
//    }

//    private bool 
//}
