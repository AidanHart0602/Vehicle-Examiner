using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedModel: MonoBehaviour
{
    [SerializeField]
    private PlacementLimiter modelLimiter;
    // Start is called before the first frame update
    void Start()
    {

    }
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
