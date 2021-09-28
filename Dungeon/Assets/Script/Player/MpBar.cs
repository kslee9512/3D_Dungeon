using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MpBar : MonoBehaviour
{
    [SerializeField]
    private Slider mpBar;

    private PlayerStat playerStat;

    // Start is called before the first frame update
    void Start()
    {
        playerStat = GameObject.Find("Player").GetComponent<PlayerStat>();

        mpBar.value = (float)playerStat.playerMp / (float)playerStat.playerMaxMp;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMp();
    }

    private void HandleMp()
    {
        mpBar.value = (float)playerStat.playerMp / (float)playerStat.playerMaxMp;
    }
}
