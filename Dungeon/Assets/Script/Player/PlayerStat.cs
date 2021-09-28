using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    [Header("Player Stat")]
    [SerializeField]
    public int playerStr;
    public int playerDex;
    public int playerDef;
    public int playerMaxHp;
    public int playerMaxMp;
    public int playerHp;
    public int playerMp;
    public int playerXp;
    public int playerMaxXp;
    public int playerLv;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        
    }
}
