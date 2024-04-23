using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    /*
    bool doorIsOpen = false;
    float doorTimer = 0.0f;
    public float doorOpenTime = 3.0f;
    public AudioClip doorOpenSound;
    public AudioClip doorShutSound;
    
    */
    GameObject currentDoor;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            RaycastHit hit;
            if(Physics.Raycast (transform.position, transform.forward, out hit, 3)){
                if(hit.collider.gameObject.tag=="playerDoor"){
                    currentDoor = hit.collider.gameObject;
                    currentDoor.gameObject.SendMessage("DoorCheck");
                }
            }
        
    }

    }

    /*
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        OpenDoor(currentDoor);
        
        if(hit.gameObject.tag == "playerDoor" && doorIsOpen == false)
        {
            currentDoor = hit.gameObject;
            OpenDoor(currentDoor);
        }

        
    }

    void OpenDoor(GameObject door)
    {
        doorIsOpen = true;
        door.GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
        door.transform.parent.GetComponent<Animation>().Play("dooropen");
    }

    void ShutDoor(GameObject door){
        doorIsOpen = false;
        door.GetComponent<AudioSource>().PlayOneShot(doorShutSound);
        door.transform.parent.GetComponent<Animation>().Play("doorshut");
    }


    
}
*/
