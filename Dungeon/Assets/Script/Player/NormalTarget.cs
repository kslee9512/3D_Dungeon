using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTarget : MonoBehaviour
{
    public List<Collider> targetList;

    void Awake()
    {
        targetList = new List<Collider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            targetList.Add(other);
        }
    }

    void OnTriggerExit(Collider other)
    {
        targetList.Remove(other);
    }

    public List<Collider> GetTargetList()
    {
        return targetList;
    }
}
