using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    /*
     추후 Stat클래스로 빠질 가능성 있음
     */ 
    [Header("Player Damage Value")]
    public int normalAttackDmg = 15;


    public NormalTarget normalTarget;
    public PlayerStat playerStat;
    // Start is called before the first frame update
    void Start()
    {
        normalTarget = GameObject.Find("NormalAttackRange").GetComponent<NormalTarget>();
        playerStat = GetComponent<PlayerStat>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NormalAttack()
    {
        foreach(Collider one in normalTarget.targetList)
        {
            EnemyStat enemy = one.GetComponent<EnemyStat>();
            if (enemy != null)
            {
                enemy.StartDamage(playerStat.playerStr * normalAttackDmg);
            }
        }
    }
}
