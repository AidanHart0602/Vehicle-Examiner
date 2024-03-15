using UnityEngine;

public class Examinable : MonoBehaviour
{ 
    [SerializeField]
    private ExaminerManager examinerManager;
    [SerializeField]
    public float primaryScaleOffset = 1f;

    // Start is called before the first frame update

    [System.Obsolete]
    void Start()
    {
        examinerManager = FindObjectOfType<ExaminerManager>();
    }

    // Update is called once per frames
    void Update()
    {

    }
    public void CallManager()
    {
        examinerManager.InvokeManager(this);
        print("Activating examiner");
    }
    public void StopManager()
    {
        examinerManager.TurnOffManager();
        print("Turning the examiner off");
    }
}
