using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    public GameObject PauseMenu;

    // Reference to the FPSCharacter script
    public FPSCharacter script;

    // Reference to the main camera
    public Camera Main_Camera;

    // Reference to the pause menu canvas
    public Canvas pauseMenuCanvas;

    // Reference to the sensitivity slider in the pause menu
    public Slider SensitivitySlider;

    void Start()

    {
        PauseMenu.SetActive(false);
        // Set the cursor lock state to Locked
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {

        // Pause the game when the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale > 0)
            {

                // Pause the game
                Time.timeScale = 0;

                PauseMenu.SetActive(true);

                // Show the pause menu
                pauseMenuCanvas.enabled = true;

                Cursor.lockState = CursorLockMode.None;
            }


            else
            {
                // Resume the game
                Time.timeScale = 1;

                PauseMenu.SetActive(false);

                // Hide the pause menu
                pauseMenuCanvas.enabled = false;

                // Unlock the cursor
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        // Update the sensitivity in the PlayerController script based on the value of the slider
        script.lookSensitivity = SensitivitySlider.value;
    }
}