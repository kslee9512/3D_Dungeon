using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorOpen : MonoBehaviour
{
    [Header("Door")]
    [SerializeField]
    GameObject doorObject;
    public int openTime;

    private float doorAngle;
    private bool playerIn;
    private bool openDoor;
    // Start is called before the first frame update
    void Start()
    {
        openDoor = false;
        doorAngle = doorObject.transform.eulerAngles.y + 90;
        if(doorAngle >= 360)
        {
            doorAngle -= 360;
        }
    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
        RotateDoor();
    }

    public void OpenDoor()
    {
        if(playerIn)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                //doorObject.transform.Rotate(new Vector3(0f, 90f, 0f) * Time.deltaTime * 5f);
                openDoor = true;
            }
        }
    }

    public void RotateDoor()
    {
        if(openDoor)
        {
            doorObject.transform.Rotate(new Vector3(0f, 90f, 0f) * Time.deltaTime * 5f);

            if(doorAngle >= 90 && doorObject.transform.eulerAngles.y >= doorAngle)
            {
                this.GetComponent<DoorOpen>().enabled = false;
            }
            else if(doorAngle <= 90 && doorObject.transform.eulerAngles.y <= doorAngle)
            {
                this.GetComponent<DoorOpen>().enabled = false;
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
