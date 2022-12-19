using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInteract : MonoBehaviour
{
    // interacts from object to player
    public GameObject player;


    private bool inRange;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 2.0f)
        {
            inRange = true;
        }
        else
        {
            inRange = false;
        }
        if (inRange && Input.GetKeyDown("f"))
        {
            Interact();
        }
    }

    void Interact()
    {
        if (tag == "Door")
        {
            Debug.Log("Interacted with door");
        }
        if (tag == "Light Switch")
        {
            Debug.Log("Interacted with light switch");
        }
    }
}
