using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberFunction : MonoBehaviour
{
    [SerializeField]
    private GameObject Thrusters;
    static public bool flamesEnabled = false;
    // Update is called once per frame
    public void ThrusterFlames()
    {
        if(flamesEnabled == true)
        {
            Thrusters.SetActive(true);
        }
        else
        {
            Thrusters.SetActive(false);
        }
    }
}
