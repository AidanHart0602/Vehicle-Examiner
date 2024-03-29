using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedModel: MonoBehaviour
{
    [SerializeField]
    private PlacementLimiter modelLimiter;
    public void callDeactivationA()
    {
        modelLimiter.Prefab1Deactivation();
    }

    public void callDeactivationB()
    {
        modelLimiter.Prefab2Deactivation();
    }
    public void callDeactivationC()
    {
        modelLimiter.Prefab3Deactivation();
    }
}
