using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private bool canActive;
    public Animator animator;
    private Collider bodyCollider;
    private EnemyPatrol enemyPatrol;
    // Start is called before the first frame update
    void Start()
    {
        canActive = true;
        animator = GetComponent<Animator>();
        bodyCollider = GameObject.Find("Skeleton").GetComponent<Collider>();
        enemyPatrol = GameObject.Find("PatrolArea").GetComponent<EnemyPatrol>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsDead()
    {
        animator.SetTrigger("IsDead");
        bodyCollider.enabled = false;
       
    }
}
