using System;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public string characterChangePath;
    public string characterName;
    [Range(1f, 100f)] public float maxHealth;
    [Range(1f, 20f)] public float speed;

    public PlayerData() { }

    public PlayerData(PlayerData data)
    {
        characterChangePath = data.characterChangePath;
        characterName = data.characterName;
        maxHealth = data.maxHealth;
        speed = data.speed;
    }
}
