using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Version2015 : MonoBehaviour
{
    public Sprite Normal;
    public Sprite CheckGreen;
    public Sprite CroixRouge;
    public Sprite PointInterrogation;
    public Sprite RedSurround;

    public GameObject MenuChooseImage;
    public GameObject[] BarImage;
    public GameObject[] GridElements;
    public GameObject[] GameElements;    

    string ImageSelected;
    string ImageTagSelected;

    string ImageNameSelected;

    TouchScreenKeyboard clavier;

    protected void Update()
    {
        if (TouchScreenKeyboard.visible == false && clavier != null)
        {
            if (clavier.status == TouchScreenKeyboard.Status.Done)
            {
                if (clavier.text == "")
                {
                    GameObject.Find(ImageNameSelected).GetComponentInChildren<TMP_Text>().text = "...";
                }

                else if (clavier.text.Length > 3)
                {
                    GameObject.Find(ImageNameSelected).GetComponentInChildren<TMP_Text>().text = "...";
                }

                else
                {
                    GameObject.Find(ImageNameSelected).GetComponentInChildren<TMP_Text>().text = clavier.text.ToUpper();
                }
                clavier = null;
                ImageNameSelected = "";
            }
        }
    }

    public void clickElement(Image image)
    {
        ImageSelected = image.name;
        ImageTagSelected = image.tag;
        MenuChooseImage.SetActive(true);
    }

    public void ClickNewImage(Image image)
    {
        Sprite lastImage = GameObject.Find(ImageSelected).GetComponent<Image>().sprite;
        Sprite newImage = Normal;

        switch (image.name)
        {
            case "Empty":
                GameObject.Find(ImageSelected).GetComponent<Image>().sprite = Normal;
                newImage = Normal;
                break;

            case "Check":
                GameObject.Find(ImageSelected).GetComponent<Image>().sprite = CheckGreen;
                newImage = CheckGreen;
                SetupBar();
                break;

            case "Croix":
                GameObject.Find(ImageSelected).GetComponent<Image>().sprite = CroixRouge;
                newImage = CroixRouge;
                break;

            case "Point":
                GameObject.Find(ImageSelected).GetComponent<Image>().sprite = PointInterrogation;
                newImage = PointInterrogation;
                break;
        }


        if (lastImage == CheckGreen && newImage != CheckGreen)
        {
            RemoveBar();
        }

        ImageSelected = "";
        MenuChooseImage.SetActive(false);
    }

    public void SurroundElement(Image image)
    {
        if(image.sprite == Normal)
        {
            GameObject.Find(image.name).GetComponent<Image>().sprite = RedSurround;
        }
        else
        {
            GameObject.Find(image.name).GetComponent<Image>().sprite = Normal;
        }
    }

    public void OpenKeyBoardAndroid(Image image)
    {
        ImageNameSelected = image.name;
        clavier = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

    void SetupBar()
    {
        switch (ImageTagSelected)
        {
            case "Olive":
                BarImage[0].SetActive(true);
                break;

            case "Moutarde":
                BarImage[1].SetActive(true);
                break;

            case "Orchidée":
                BarImage[2].SetActive(true);
                break;

            case "Leblanc":
                BarImage[2].SetActive(true);
                break;

            case "Pervenche":
                BarImage[3].SetActive(true);
                break;

            case "Violet":
                BarImage[4].SetActive(true);
                break;

            case "Rose":
                BarImage[5].SetActive(true);
                break;

            case "Chandelier":
                BarImage[6].SetActive(true);
                break;

            case "Poignard":
                BarImage[7].SetActive(true);
                break;

            case "Barre de fer":
                BarImage[8].SetActive(true);
                break;

            case "Révolver":
                BarImage[9].SetActive(true);
                break;

            case "Corde":
                BarImage[10].SetActive(true);
                break;

            case "Clé anglaise":
                BarImage[11].SetActive(true);
                break;

            case "Salle de réception":
                BarImage[12].SetActive(true);
                break;

            case "Salle de billard":
                BarImage[13].SetActive(true);
                break;

            case "Jardin d'hiver":
                BarImage[14].SetActive(true);
                break;

            case "Salle à manger":
                BarImage[15].SetActive(true);
                break;

            case "Entrée":
                BarImage[16].SetActive(true);
                break;

            case "Cuisine":
                BarImage[17].SetActive(true);
                break;

            case "Bibliothèque":
                BarImage[18].SetActive(true);
                break;

            case "Salon":
                BarImage[19].SetActive(true);
                break;

            case "Bureau":
                BarImage[20].SetActive(true);
                break;
        }

        ImageTagSelected = "";
    }

    void RemoveBar()
    {
        switch (ImageTagSelected)
        {
            case "Olive":
                BarImage[0].SetActive(false);
                break;

            case "Moutarde":
                BarImage[1].SetActive(false);
                break;

            case "Orchidée":
                BarImage[2].SetActive(false);
                break;

            case "Pervenche":
                BarImage[3].SetActive(false);
                break;

            case "Violet":
                BarImage[4].SetActive(false);
                break;

            case "Rose":
                BarImage[5].SetActive(false);
                break;

            case "Chandelier":
                BarImage[6].SetActive(false);
                break;

            case "Poignard":
                BarImage[7].SetActive(false);
                break;

            case "Barre de fer":
                BarImage[8].SetActive(false);
                break;

            case "Révolver":
                BarImage[9].SetActive(false);
                break;

            case "Corde":
                BarImage[10].SetActive(false);
                break;

            case "Clé anglaise":
                BarImage[11].SetActive(false);
                break;

            case "Salle de réception":
                BarImage[12].SetActive(false);
                break;

            case "Salle de billard":
                BarImage[13].SetActive(false);
                break;

            case "Jardin d'hiver":
                BarImage[14].SetActive(false);
                break;

            case "Salle à manger":
                BarImage[15].SetActive(false);
                break;

            case "Entrée":
                BarImage[16].SetActive(false);
                break;

            case "Cuisine":
                BarImage[17].SetActive(false);
                break;

            case "Bibliothèque":
                BarImage[18].SetActive(false);
                break;

            case "Salon":
                BarImage[19].SetActive(false);
                break;

            case "Bureau":
                BarImage[20].SetActive(false);
                break;
        }
    }

    public void resetButton()
    {
        // Remove Image
        foreach (GameObject item in GridElements)
        {
            if(item.GetComponent<Image>().sprite != Normal)
            {
                item.GetComponent<Image>().sprite = Normal;
            }
        }

        foreach (GameObject item in GameElements)
        {
            if(item.GetComponent<Image>().sprite != Normal)
            {
                item.GetComponent<Image>().sprite = Normal;
            }
        }

        // Remove Bar
        foreach (GameObject item in BarImage)
        {
            if(item.activeSelf == true)
            {
                item.SetActive(false);
            }
        }
    }
}
