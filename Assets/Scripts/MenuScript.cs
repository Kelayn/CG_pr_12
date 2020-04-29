using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{

    GameObject menu;
    
    void Start()
    {
        menu =  GameObject.Find("Menu");
    }

    public void StartScene()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Options(GameObject options)
    {
        menu.SetActive(!menu.activeSelf);
        options.SetActive(!options.activeInHierarchy);
    }

 

}
