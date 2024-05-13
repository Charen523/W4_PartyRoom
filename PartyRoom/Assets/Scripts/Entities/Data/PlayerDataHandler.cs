using UnityEngine;
using UnityEngine.UI;

public class PlayerDataHandler : MonoBehaviour
{
    public PlayerData currentStat {  get; private set; }
    public GameObject nameTag;

    private Text nameText;
    private RectTransform nameRect;

    void Awake()
    {
        nameText = nameTag.GetComponent<Text>();
        nameRect = nameTag.GetComponent<RectTransform>();   
    }

    public void LoadPlayerData(PlayerData data)
    {
        data = new PlayerData(currentStat);
    }

    public PlayerData SavePlayerData()
    {
        return new PlayerData(currentStat);
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
        nameText.text = characterName;
        UIUtility.SetTextRectSize(nameText, nameRect);

        Debug.Log("Character name updated to: " + characterName);
    }
}
