using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject CurrentVersion;
    public GameObject ChooseVersion;

    public void RETOUR()
    {
        CurrentVersion.SetActive(false);
        ChooseVersion.SetActive(true);
    }
}
