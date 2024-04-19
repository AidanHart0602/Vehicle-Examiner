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
    private Vector3 cachedScale;

    [SerializeField]
    private float RotationSpeed = .25f;
    private bool ExamineActive = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                
                if (ExamineActive == true)
                {
                    selectedPlacementObject.transform.Rotate(touch.deltaPosition.y * RotationSpeed, touch.deltaPosition.x * -1 * RotationSpeed, 0);
                }
            }
            print("Touch has been Detected");
            
        }
    }

    public void InvokeManager(Examinable Examinable)
    {
        ExamineActive = true;
        selectedPlacementObject = Examinable;

        cachedPosition = Examinable.transform.position;
        cachedRotation = Examinable.transform.rotation;
        cachedScale = Examinable.transform.localScale;

        Vector3 secondaryScaleOffset = cachedScale * Examinable.primaryScaleOffset;

        Examinable.transform.position = targetTransform.transform.position;
        Examinable.transform.rotation = targetTransform.transform.rotation;
    }

    public void TurnOffManager()
    {
        selectedPlacementObject.transform.position = cachedPosition;
        selectedPlacementObject.transform.rotation = cachedRotation;
        selectedPlacementObject = null;
        ExamineActive = false;
    }

}
