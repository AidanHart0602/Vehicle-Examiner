using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
public class Examinable : MonoBehaviour
{
    [SerializeField]
    public ARSelectionInteractable examinableSelection;
    [SerializeField]
    public ARSelectionInteractable regularSelection;
   
    [SerializeField]
    public ExaminerManager examinerManager;
    [SerializeField]
    public float primaryScaleOffset = 1f;

    // Start is called before the first frame update

    [System.Obsolete]
    public void FindManager()
    {
        examinableSelection.enabled = true;
        regularSelection.enabled = false;
        examinerManager = FindObjectOfType<ExaminerManager>();
    }
    public void DisableManager()
    {
        examinableSelection.enabled = false;
        regularSelection.enabled = true;
        examinerManager = null;
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
