using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> plantingGrids;
    [SerializeField] private List<GameObject> menuItem;
    [SerializeField]private bool hideGrid = true;

    private GameObject ui_Menu, sunflowerIcon, zoomBar, zoomIcon, settings;
    public TMPro.TextMeshProUGUI helpText;

    private Highlight highlightScript;


    private void Start()
    {
        ui_Menu = GameObject.Find("SeedMenu");
        sunflowerIcon = GameObject.Find("PlantingIcon");
        zoomBar = GameObject.Find("Zoom Bar");
        zoomIcon = GameObject.Find("ZoomIcon");
        settings = GameObject.Find("MenuIcon");

        highlightScript = FindObjectOfType<Highlight>();

        //Finds all planting grids in the scene and adds them to the list plantingGrids
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("PlantingGrid"))
        {
            plantingGrids.Add(go);
        }       

        foreach(GameObject slot in GameObject.FindGameObjectsWithTag("MenuIcons"))
        {
            menuItem.Add(slot);
            slot.GetComponent<Button>().interactable = false;
        }

    }

    private void Update()
    {
        //Loops through the list of grids and sets them to true or false 
        for(int i = 0; i < plantingGrids.Count; i++)
        {
            if (hideGrid)
            {
                plantingGrids[i].SetActive(false);
            }

            else if (!hideGrid)
            {
                plantingGrids[i].SetActive(true);
            }
        }

        //helpText.text = "Select a space to plant your flower";

        for (int i = 0; i < menuItem.Count; i++)
        {
            if (!highlightScript.selected)
            {
               
                menuItem[i].GetComponent<Button>().interactable = false;
            }
            else
            {
                menuItem[i].GetComponent<Button>().interactable = true;
            }

            if (!menuItem[i].GetComponent<Button>().interactable)
            {
                helpText.text = "Select a space to plant your flower";
            }
            else
            {
                helpText.text = "Select a seed to plant";
            }

        }

    }

    // Sunflower Icon - Sets the value of the hideGrid bool which determines if the grids should be shown or not
    public void SeedMenu()
    {
        if (!hideGrid)
        {
            hideGrid = true;
            highlightScript.highlightedGrid = null;
            highlightScript.gridToPlant = null;
            LeanTween.move(ui_Menu.GetComponent<RectTransform>(), new Vector3(0, -520f, 0), 0.5f).setOnComplete(ShowMe);
        }

        else if (hideGrid)
        {
            hideGrid = false;
            LeanTween.move(ui_Menu.GetComponent<RectTransform>(), new Vector3(0, 0, 0), 0.5f);
            sunflowerIcon.SetActive(false);
            zoomBar.SetActive(false);
            zoomIcon.SetActive(false);
        }
    }

    public void ShowMe()
    {
        sunflowerIcon.SetActive(true);
        highlightScript.selected = false;
        zoomBar.SetActive(true);
        zoomIcon.SetActive(true);
    }

}
