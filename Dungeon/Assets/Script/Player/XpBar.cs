using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class XpBar : MonoBehaviour
{
    [SerializeField]
    private Slider xpBar;

    private PlayerStat playerStat;

    // Start is called before the first frame update
    void Start()
    {
        playerStat = GameObject.Find("Player").GetComponent<PlayerStat>();
        xpBar.value = (float)playerStat.playerXp / (float)playerStat.playerMaxXp;
    }

    // Update is called once per frame
    void Update()
    {
        HandleXpBar();
    }

    private void HandleXpBar()
    {
        xpBar.value = (float)playerStat.playerXp / (float)playerStat.playerMaxXp;
    }
}
