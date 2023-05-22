using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SetObjectsActive : MonoBehaviour

{
    public GameObject[] genieOnObjects; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Battery"))
        {
            ActivateGenieOnObjects();
            DeactivateGenieOffObjects();
        }
    }

    private void ActivateGenieOnObjects()
    {
        foreach (GameObject obj in genieOnObjects)
        {
            if (!obj.activeSelf)
            {
                obj.SetActive(true);
            }
        }
    }

    private void DeactivateGenieOffObjects()
    {
        GameObject[] genieOffObjects = GameObject.FindGameObjectsWithTag("genieOff");

        foreach (GameObject obj in genieOffObjects)
        {
            obj.SetActive(false);
        }
    }
}
