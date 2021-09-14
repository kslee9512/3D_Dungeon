using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStat : MonoBehaviour
{
    [Header("EnemyStat")]
    [SerializeField]
    public int enemyHp;
    public int enemySpeed;
    public int enemyDef;
    public int enemyStr;

    public EnemyMovement enemyMovement;
    private bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        enemyMovement = GetComponent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIsAlive();
    }

    public void StartDamage(int damage)
    {
        int calcDamage = damage - (enemyDef * 5);
        enemyHp -= calcDamage;
        if(enemyHp > 0)
        {
            enemyMovement.animator.SetTrigger("GetDamage");
        }
    }

    public void CheckIsAlive()
    {
        if(enemyHp <= 0 && isAlive)
        {
            isAlive = false;
            enemyMovement.IsDead();
        }
    }
}
