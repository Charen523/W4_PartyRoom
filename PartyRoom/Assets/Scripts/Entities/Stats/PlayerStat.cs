using System;
using UnityEngine;

[Serializable]
public class PlayerStat
{
    public string characterChangePath;
    public string characterName;
    [Range(1f, 100f)] public float maxHealth;
    [Range(1f, 20f)] public float speed;
}
