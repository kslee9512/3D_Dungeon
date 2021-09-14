using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [Header("Door")]
    [SerializeField]
    GameObject doorObject;

    private bool playerIn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
    }

    public void OpenDoor()
    {
        if(playerIn)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                doorObject.transform.Rotate(new Vector3(0f, 90f, 0f) * Time.deltaTime * 5f);
            }
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIn = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        playerIn = false;
    }
}
