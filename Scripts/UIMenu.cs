using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

        foreach(GameObject Prefab in PrefabsList)
        {
            Destroy(Prefab);
        }
    }
}
