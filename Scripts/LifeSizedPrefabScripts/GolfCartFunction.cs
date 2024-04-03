using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfCartFunction : MonoBehaviour
{
    [SerializeField]
    private GameObject headLights;

    public void EnableHeadlights()
    {
        Debug.Log("Lights Active");
        headLights.SetActive(true);
    }
    public void DisableHeadLights()
    { 
        headLights.SetActive(false);
    }
}
