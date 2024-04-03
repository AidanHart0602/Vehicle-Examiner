using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberFunction : MonoBehaviour
{
    [SerializeField]
    private GameObject Thrusters;
    // Update is called once per frame
    public void ActivateThrusterFlames()
    {
        Thrusters.SetActive(true);
    }
    public void DeactivateThrusterFlames()
    {
        Thrusters.SetActive(false);
    }
}
