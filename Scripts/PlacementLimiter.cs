using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementLimiter : MonoBehaviour
{ 
    public GameObject placementButtonA;
    public GameObject placementButtonB;
    public GameObject placementButtonC;

    [SerializeField]
    private bool prefabAisActive = true;
    [SerializeField]
    private bool prefabBisActive = true;
    [SerializeField]
    private bool prefabCisActive = true;

    private void Update()
    {
        ButtonCheck();            
    }

    public void ButtonCheck()
    {
       if(prefabAisActive == false)
        {
            placementButtonA.SetActive(false);
        }
        else
        {
            placementButtonA.SetActive(true);
        }
        if (prefabBisActive == false)
        {
            placementButtonB.SetActive(false);
        }
        else
        {
            placementButtonB.SetActive(true);
        }
        if (prefabCisActive == false)
        {
            placementButtonC.SetActive(false);
        }
        else
        {
            placementButtonC.SetActive(true);
        }
    }
    public void Prefab1Deactivation()
    {
        prefabAisActive = false;
    }
    public void Prefab2Deactivation()
    {
        prefabBisActive = false;
    }
    public void Prefab3Deactivation()
    {
        prefabCisActive = false;
    }

    public void DeactivateAllPrefabs()
    {
        prefabAisActive = false;
        prefabBisActive = false;
        prefabCisActive = false;
    }
    public void ReActivate()
    {
        prefabAisActive = true;
        prefabBisActive = true;
        prefabCisActive = true;
    }

     
}
