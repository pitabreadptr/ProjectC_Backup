using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFlashLightStatus : MonoBehaviour
{
    public GameObject flashLight;
 
    public void SwitchStatus()
    {
        if (flashLight.activeSelf)
        {
            flashLight.SetActive(false);
        }
        else
        {
            flashLight.SetActive(true);
        }
    }
}
