using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenu; // Assign in Inspector
    public Slider SensitivitySlider; // Assign in Inspector
    public FPSCharacter script; //allows me to reference FPSCharacter script
   

    private bool isPaused = false;
    public float sensitivity;

    void Update()
    {
        //Toggle pause with escape key
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isPaused = !isPaused;
            pauseMenu.SetActive(isPaused);
            script.enabled = !isPaused;
            Cursor.visible = isPaused;
            Cursor.lockState = isPaused ? CursorLockMode.None : CursorLockMode.Locked;
        }

        // Update pause state
        if (isPaused)
        {
            Time.timeScale = 0f; // Freeze time
            UnityEngine.Cursor.lockState = CursorLockMode.None; // Show cursor
            UnityEngine.Cursor.visible = true; // Show cursor
            pauseMenu.SetActive(true); // Show pause menu
            AudioListener.pause = true;
        }
        else
        {
            Time.timeScale = 1f; // Unfreeze time
            UnityEngine.Cursor.lockState = CursorLockMode.Locked; // Hide cursor
            UnityEngine.Cursor.visible = false; // Hide cursor
            pauseMenu.SetActive(false); // Hide pause menu

            // Update sensitivity value when game is resumed
            sensitivity = SensitivitySlider.value;

            // Set sensitivity in FPSCharacter script
            script.lookSensitivity = sensitivity;

            AudioListener.pause = false;


        }

    }

    public void OnSensitivityChanged()
    {
        // Update sensitivity value when slider is changed
        sensitivity = SensitivitySlider.value;
    }
}