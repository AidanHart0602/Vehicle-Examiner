using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelActivationScript : MonoBehaviour
{
    private BomberFunction bombFunc;
    private GolfCartFunction cartFunc;
    private void Start()
    {
        bombFunc = bombFunc.GetComponent<BomberFunction>();
        cartFunc = cartFunc.GetComponent<GolfCartFunction>();
    }

    public void ActivateModels()
    {
        BomberFunction.flamesEnabled = true;
        bombFunc.ThrusterFlames();

        GolfCartFunction.lightsEnabled = true;
        cartFunc.HeadLights();
    }

    public void DeactivateModels()
    {
        BomberFunction.flamesEnabled = false;
        bombFunc.ThrusterFlames();

        GolfCartFunction.lightsEnabled = false;
        cartFunc.HeadLights();
    }
}
