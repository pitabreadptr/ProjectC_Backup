using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareTrigger : MonoBehaviour
{
    // The object that will be used to jump scare the player
    public GameObject jumpScareObject;

    // The distance at which the player will trigger the jump scare
    public float triggerDistance = 2.0f;

    // The amount of time that the jump scare object will be active for
    public float jumpScareDuration = 1.0f;

    // A reference to the player object
    public GameObject player;

    // A timer to track how long the jump scare object has been active
    private float jumpScareTimer = 0.0f;

    void Start()
    {
        jumpScareObject.SetActive(false);
        gameObject.SetActive(true);
        // Find the player object in the scene
    }

    void Update()
    {
        // Calculate the distance between the player and the jump scare trigger
        float distance = Vector3.Distance(player.transform.position, transform.position);

        // If the player is within the trigger distance, start the jump scare
        if (distance < triggerDistance)
        {
            // Activate the jump scare object
            jumpScareObject.SetActive(true);  
        }


        if (jumpScareObject.activeSelf)
        {
            // Increment the jump scare timer
            jumpScareTimer += Time.deltaTime;

            // If the jump scare timer exceeds the jump scare duration, deactivate the jump scare object
            if (jumpScareTimer > jumpScareDuration)
            {
                jumpScareObject.SetActive(false);
                jumpScareTimer = 0.0f;
            }
        }
    }
}
