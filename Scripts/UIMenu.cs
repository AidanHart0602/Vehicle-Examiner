using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class UIMenu : MonoBehaviour
{
    private Examinable examinable;
    private void Start()
    {

    }
    private void Update()
    {
        
    }
    public void LoadStartingMenu()
    {
        SceneManager.LoadScene("UI Menu");
    }

    public void LoadDesktopMode()
    {
        SceneManager.LoadScene("Desktop Mode");
    }

    public void LoadDrivewayMode()
    {
        SceneManager.LoadScene("Driveway Mode");
    }


    public void DestroyModels()
    {
        GameObject[] PrefabsList = GameObject.FindGameObjectsWithTag("Prefab");

        foreach (GameObject Prefab in PrefabsList)
        {
            Destroy(Prefab);            
        }
    }


    [System.Obsolete]
    public void MakeModelsExaminable() 
    {
        GameObject[] PrefabsList = GameObject.FindGameObjectsWithTag("Prefab");

        foreach(GameObject Prefab in PrefabsList)
        {
            Prefab.GetComponent<ARTranslationInteractable>().enabled = false;
            Prefab.GetComponent<ARScaleInteractable>().enabled = false;
            Prefab.GetComponent<ARRotationInteractable>().enabled = false;
            Prefab.GetComponent<Examinable>().enabled = true;
            Prefab.GetComponent<Examinable>().FindManager();
        }
    }
    [System.Obsolete]
    public void UndoExamination()
    {
        GameObject[] PrefabsList = GameObject.FindGameObjectsWithTag("Prefab");

        foreach (GameObject Prefab in PrefabsList)
        {
            Prefab.GetComponent<ARTranslationInteractable>().enabled = true;
            Prefab.GetComponent<ARScaleInteractable>().enabled = true;
            Prefab.GetComponent<ARRotationInteractable>().enabled = true;
            Prefab.GetComponent<Examinable>().enabled = false;
            Prefab.GetComponent<Examinable>().DisableManager();
        }
    }
}

