using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelActivationScript : MonoBehaviour
{
    private BomberFunction bombFunc;
    private GolfCartFunction cartFunc;
    private HelicopterFunction heliFunc;
   
    private void SearchPrefabs()
    {
        bombFunc = Object.FindFirstObjectByType<BomberFunction>();
        cartFunc = Object.FindFirstObjectByType<GolfCartFunction>();
        heliFunc = Object.FindFirstObjectByType<HelicopterFunction>();
    }
    public void ActivateModels()
    {
        SearchPrefabs();

        if (cartFunc != null)
        {
            Debug.Log("Cart Function is not null");
            cartFunc.EnableHeadlights();
        }
        if (bombFunc != null)
        {
            Debug.Log("Bomber Function is not null");
            bombFunc.ActivateThrusterFlames();
        }
        if(heliFunc != null)
        {
            Debug.Log("Helicopter Function is not null");
            heliFunc.ActivateBlades();
        }
    }
    public void DeactivateModels()
    {
        SearchPrefabs();
        if (cartFunc != null)
        {
            Debug.Log("Cart Function is not null");
            cartFunc.DisableHeadLights();
        }
        if (bombFunc != null)
        {
            Debug.Log("Bomber Function is not null");
            bombFunc.DeactivateThrusterFlames();
        }
        if (heliFunc != null)
        {
            Debug.Log("Helicopter Function is not null");
            heliFunc.DeactivateBlades();
        }
    }    
}
