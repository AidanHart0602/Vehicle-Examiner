using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterFunction : MonoBehaviour
{
    [SerializeField]
    private GameObject helicopterBlades;
    private bool activate = false;

    // Update is called once per frame
    void Update()
    {
        if(activate == true)
        {
            helicopterBlades.transform.Rotate(0f, 10f, 0f, Space.Self);
        }
    }

    public void ActivateBlades()
    {
        activate = true;
    }

    public void DeactivateBlades() 
    {
        activate = false;
    }

}
