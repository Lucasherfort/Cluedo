using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoixVersion : MonoBehaviour
{
    public GameObject choixVersion;
    public GameObject V_2012;
    public GameObject V_2015;
    public GameObject V_2017;
    public GameManager gameManager;

    void Start() 
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();    
    }

    public void V2012()
    {
        choixVersion.SetActive(false);
        V_2012.SetActive(true);
        gameManager.CurrentVersion = GameObject.Find("2012");
    }

    public void V2015()
    {
        choixVersion.SetActive(false);
        V_2015.SetActive(true);
        gameManager.CurrentVersion = GameObject.Find("2015");
    }

    public void V2017()
    {
        choixVersion.SetActive(false);
        V_2017.SetActive(true);
        gameManager.CurrentVersion = GameObject.Find("2017");
    }

}
