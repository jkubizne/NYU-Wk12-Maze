using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWinState : MonoBehaviour
{
    public List<GameObject> winStateObjects;
    public string genieOnTag = "genieOn";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateWinStateObjects();
            DeactivateGenieOnObjects();
        }
    }

    private void ActivateWinStateObjects()
    {
        foreach (GameObject obj in winStateObjects)
        {
            if (!obj.activeSelf)
            {
                obj.SetActive(true);
            }
        }
    }

    private void DeactivateGenieOnObjects()
    {
        GameObject[] genieOnObjects = GameObject.FindGameObjectsWithTag(genieOnTag);

        foreach (GameObject obj in genieOnObjects)
        {
            obj.SetActive(false);
        }
    }
}