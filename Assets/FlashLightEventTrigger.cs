using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FlashLightEventTrigger : MonoBehaviour
{

    public UnityEvent switchFlashLightStatus;

    // for later when equip system is implemented
    private bool equipped = true;

    // Update is called once per frame
    void Update()
    {
        if (equipped && Input.GetKeyDown("v"))
        {
            Debug.Log("Pressed");
            switchFlashLightStatus.Invoke();
        }
    }
}
