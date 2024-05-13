using UnityEngine;
using UnityEngine.UI;

public class PlayerDataHandler : MonoBehaviour
{
    public PlayerData currentStat {  get; private set; }

    private Text nameText;
    private RectTransform nameRect;

    void Awake()
    {
        Transform nameTag = transform.Find("Canvas/NameBox/NameTxt");
    
        nameText = nameTag.GetComponent<Text>();
        nameRect = nameTag.GetComponent<RectTransform>();   
    }

    public void LoadPlayerData(PlayerData data)
    {
        currentStat = new PlayerData(data);
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
    }
}
