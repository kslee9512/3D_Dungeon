using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    [SerializeField]
    private Slider hpBar;

    private PlayerStat playerStat;
    // Start is called before the first frame update
    void Start()
    {
        playerStat = GameObject.Find("Player").GetComponent<PlayerStat>();
        hpBar.value = (float)playerStat.playerHp / (float)playerStat.playerMaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerStat.playerHp -= 10;
            HandleHp();
        }
    }

    private void HandleHp()
    {
        hpBar.value = (float)playerStat.playerHp / (float)playerStat.playerMaxHp;
    }
}
