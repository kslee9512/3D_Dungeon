using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowingCamera : MonoBehaviour
{
    public Transform follow;
    public float distanceAway = 4f;
    public float distanceUp = 20f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = follow.position + Vector3.up * distanceUp - 
            Vector3.forward * distanceAway;        
    }
}
