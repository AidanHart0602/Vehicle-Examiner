using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelFunctionality : MonoBehaviour
{
    [SerializeField]
    private GameObject headLights;
    [SerializeField]
    private GameObject heliBlades;
    private bool headLightActive = false;
    private bool helicopterActive = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GolfCart();
        HelicopterRotate();
    }

    public void GolfCart()
    {
        if(headLightActive == true)
        {
            headLights.SetActive(true);
        }
        else 
        {
            headLights.SetActive(false);
        }
     
    }

    public void HelicopterRotate()
    {
        if(helicopterActive == true)
        {
            heliBlades.transform.Rotate(0f, 1, 0f, Space.Self);
        }
        else
        {
            transform.Rotate(0f, 0f, 0f);
        }
    }

    public void ActivateFunctions()
    {
        headLightActive = true;
        helicopterActive = true;
    }

    public void DeactivateFunctions()
    {
        headLightActive = false;
        helicopterActive = false;
    }
}
