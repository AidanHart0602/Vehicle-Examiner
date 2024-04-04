using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;


[RequireComponent(typeof(ARPlaneManager))]
public class EnableAndDisablePlanes : MonoBehaviour
{
    private ARPlaneManager planeManager;
    [SerializeField]
    private TMP_Text TogglePlanesText;

    [System.Obsolete]
    private void Start()
    {
        TogglePlanesText = FindObjectOfType<TextMeshProUGUI>();
        planeManager = GetComponent<ARPlaneManager>();
    }

    public void TogglePlaneDetection() 
    {
        planeManager.enabled = !planeManager.enabled;
        string togglePlaneText = "";

        if (planeManager.enabled)
        {
            togglePlaneText = "Disable Planes";
            AllPlanesActive(true);
            TogglePlanesText.text = togglePlaneText;
        }
        else
        {
            togglePlaneText = "Enable Planes";
            AllPlanesActive(false);
            TogglePlanesText.text = togglePlaneText;
        }
    }

    private void AllPlanesActive(bool toggle)
    {
        foreach(var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(toggle);
        }
    }

    public void TogglePlaneDetectionWithoutText()
    {
        planeManager.enabled = !planeManager.enabled;

        if (planeManager.enabled)
        {
            AllPlanesActive(true);
        }
        else
        {
            AllPlanesActive(false);
        }
    }
}
