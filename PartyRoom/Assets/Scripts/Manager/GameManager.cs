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
            SpawnPlayer(); //���� �÷��̾� ����
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    //���ο� �� ����
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
            Debug.LogError("�÷��̾� ��ü ���� ����");
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
        currentPlayer.transform.position = new Vector3(0, 0, 0); // ��ġ �ʱ�ȭ
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
        currentPlayer = null; //���� ����
    }
}
