using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public GameObject playerPrefab;
    public GameObject currentPlayer;

    [SerializeField] private PlayerData baseStats;
    
    public PlayerData savePlayerData;

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
            return;
        }

        if (currentPlayer == null)
        {
            SpawnPlayer(); //최초 플레이어 생성
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
        {
            DestroyPlayer();
            Debug.Log("Destroyed");
        }

        if (currentPlayer == null)
            SpawnPlayer();
        else
            Debug.LogError("플레이어 객체 삭제 오류");
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
        currentPlayer.GetComponent<PlayerDataHandler>().setCharacterName(savePlayerData.characterName);

        if (SceneManager.GetActiveScene().name == "StartScene")
            currentPlayer.SetActive(false);
        else
            currentPlayer.SetActive(true);
    }

    private void DestroyPlayer()
    {
        savePlayerData = currentPlayer.GetComponent<PlayerDataHandler>().SavePlayerData();
        Destroy(currentPlayer);
        currentPlayer = null; //참조 제거
    }
}
