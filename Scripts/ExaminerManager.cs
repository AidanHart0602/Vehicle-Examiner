using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaminerManager : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform;
    private Examinable selectedPlacementObject;
    private Vector3 cachedPosition;
    private Quaternion cachedRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InvokeManager(Examinable Examinable)
    {
        selectedPlacementObject = Examinable;

        cachedPosition = Examinable.transform.position;
        cachedRotation = Examinable.transform.rotation;

        Examinable.transform.position = targetTransform.transform.position;
        Examinable.transform.rotation = targetTransform.transform.rotation;
    }

    public void TurnOffManager()
    {
        selectedPlacementObject.transform.position = cachedPosition;
        selectedPlacementObject.transform.rotation = cachedRotation;
        selectedPlacementObject = null;
    }
}
