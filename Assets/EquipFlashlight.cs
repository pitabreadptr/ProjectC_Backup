using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipFlashlight : MonoBehaviour
{
    public GameObject flashlightPrefab; // Drag the flashlight prefab into this field in the Inspector

    private GameObject flashlightInstance; // The instance of the flashlight prefab that will be created when the E key is pressed
    public Transform flashlightParent; // The transform to parent the flashlight instance to (e.g. the player character's hand)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // If the flashlight instance doesn't exist, create it and parent it to the flashlightParent transform
            if (flashlightInstance == null)
            {
                flashlightInstance = Instantiate(flashlightPrefab, flashlightParent);
                flashlightInstance.transform.parent = flashlightParent;
            }
            // If the flashlight instance already exists, destroy it
            else
            {
                Destroy(flashlightInstance);
                flashlightInstance = null;
            }
        }
    }
}
