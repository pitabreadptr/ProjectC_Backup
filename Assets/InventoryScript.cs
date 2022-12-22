using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public GameObject pauseMenu; // Assign in Inspector
    public GameObject inventoryMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            // Toggle the visibility of the inventory menu
            inventoryMenu.SetActive(!inventoryMenu.activeSelf);
            
        }

        if (Input.GetKeyDown(KeyCode.Tab) && inventoryMenu.activeSelf)
        {
            // Close the inventory menu if it is currently open
            inventoryMenu.SetActive(false);
        }
    }

}