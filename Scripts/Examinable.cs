using UnityEngine;

public class Examinable : MonoBehaviour
{

    [SerializeField]
    private ExaminerManager ExaminerManager;
    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        ExaminerManager = FindObjectOfType<ExaminerManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CallManager()
    {
        ExaminerManager.InvokeManager(this);
        print("Activating examiner");
    }

    public void StopManager()
    {
        ExaminerManager.TurnOffManager();
        print("Turning the examiner off");
    }

    void checkVisualization()
    {
        if (visualizeSelection == true)
        {

        }
    }
}
