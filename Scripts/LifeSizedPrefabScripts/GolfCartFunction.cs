using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfCartFunction : MonoBehaviour
{
    [SerializeField]
    private GameObject headLights;
    static public bool lightsEnabled = false;
    // Update is called once per frame
    public void HeadLights()
    {
        if (lightsEnabled == true)
        {
            headLights.SetActive(true);
            print("FunctionActivated");
        }
        else
        {
            headLights.SetActive(false);
        }
    }
}
