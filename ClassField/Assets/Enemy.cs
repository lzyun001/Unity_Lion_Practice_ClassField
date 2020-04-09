using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("血量"),Tooltip("怪物的血量"),Range(50, 500)]
    public int hp;

    [Header("魔力"), Tooltip("怪物的魔力"), Range(10, 100)]
    public int mp = 100;

    [Header("能力值"), Range(1, 50.5f)]
    public float ms = 10.5f;
    [Range(0, 100)]
    public int att = 50;
    [Range(0, 100)]
    public int def;

    [Header("裝備")]
    public string weapon;
    public string equipment = "皮衣";

    [Header("其他資料"), Tooltip("怪物是否帶有鑰匙")]
    public bool key;
    [Tooltip("怪物是否帶有寶物"),]
    public bool treasure;
}
