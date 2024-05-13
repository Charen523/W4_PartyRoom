using UnityEngine;

public class PlayerStatHandler : MonoBehaviour
{
    [SerializeField] private PlayerStat baseStats;
    public PlayerStat currentStat {  get; private set; }

    void Awake()
    {
        resetPlayerStat();
    }

    private void resetPlayerStat()
    {
        currentStat = new PlayerStat
        {
            characterChangePath = baseStats.characterChangePath,
            characterName = baseStats.characterName,
            maxHealth = baseStats.maxHealth,
            speed = baseStats.speed
        };
    }

    public void setCharacterImage(string imageFolder)
    {
        if (imageFolder != null)
        {
            currentStat.characterChangePath = imageFolder;
            Debug.Log("Character image path updated to: " + imageFolder);
        }
    }

    public void setCharacterName(string characterName)
    {
        currentStat.characterName = characterName;
        Debug.Log("Character name updated to: " + characterName);
    }
}
