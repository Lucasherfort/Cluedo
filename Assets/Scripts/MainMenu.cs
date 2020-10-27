using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject ChoixVersion;
    public GameObject V2012;
    public GameObject V2015;
    public GameObject V2017;

    private void Start()
    {
        mainMenu.SetActive(true);
        ChoixVersion.SetActive(false);
        V2012.SetActive(false);
        V2015.SetActive(false);
        V2017.SetActive(false);
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
