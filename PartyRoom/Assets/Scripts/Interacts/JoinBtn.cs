using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinBtn : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("LobbyScene");
    }
}
