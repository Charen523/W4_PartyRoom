using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCButton : MonoBehaviour
{
    public GameObject InteractPanel;
    public GameObject SpeakPanel;

   public void OnInteractButton()
    {
        InteractPanel.SetActive(false);
        SpeakPanel.SetActive(true);
    }
   
    public void OnCheckButton()
    {
        SpeakPanel.SetActive(false);
    }
}
