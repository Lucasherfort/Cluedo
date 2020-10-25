using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject ChoixVersion;

    private void Start()
    {
        mainMenu.SetActive(true);
    } 


    public void START()
    {
        mainMenu.SetActive(false);
        ChoixVersion.SetActive(true);
    }

    public void QUITTER()
    {
        Application.Quit();
    }
}
