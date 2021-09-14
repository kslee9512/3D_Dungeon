using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField]
    List<Collider> playerTarget;

    private void Awake()
    {
        playerTarget = new List<Collider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerTarget.Add(other);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        playerTarget.Remove(other);
    }
}
