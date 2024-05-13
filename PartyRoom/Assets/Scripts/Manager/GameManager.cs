using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public GameObject playerPrefab;
    private GameObject currentPlayer;

    [SerializeField] private PlayerData baseStats;
    private PlayerData savePlayerData;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            ResetPlayerData();
        }
        else
        {
            Destroy(gameObject);
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    //새로운 씬 진입
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (currentPlayer != null)
            DestroyPlayer();
        SpawnPlayer();
    }

    private void ResetPlayerData()
    {
        savePlayerData = new PlayerData
        {
            characterChangePath = baseStats.characterChangePath,
            characterName = baseStats.characterName,
            maxHealth = baseStats.maxHealth,
            speed = baseStats.speed
        };
    }

    private void SpawnPlayer()
    {
        currentPlayer = Instantiate(playerPrefab);
        currentPlayer.transform.position = new Vector3(0, 0, 0); // 위치 초기화
        currentPlayer.GetComponent<PlayerDataHandler>().LoadPlayerData(savePlayerData);
    }

    private void DestroyPlayer()
    {
        savePlayerData = currentPlayer.GetComponent<PlayerDataHandler>().SavePlayerData();
        Destroy(currentPlayer);
    }
}
