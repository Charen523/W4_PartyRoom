using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDataHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private NPCData myData;

    private void Start()
    {
        
    }

    public string GetNPCName()
    {
        return myData.characterName;
    }
}
