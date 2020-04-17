using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> plantingGrids;
    [SerializeField]private bool hidden = true;
    private GameObject ui_Menu, sunflowerIcon, zoomBar, zoomIcon, settings;

    private void Start()
    {
        ui_Menu = GameObject.Find("SeedMenu");
        sunflowerIcon = GameObject.Find("PlantingIcon");
        zoomBar = GameObject.Find("Zoom Bar");
        zoomIcon = GameObject.Find("ZoomIcon");
        settings = GameObject.Find("MenuIcon");

        //Finds all planting grids in the scene and adds them to the list plantingGrids
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("PlantingGrid"))
        {
            plantingGrids.Add(go);
        }       
    }

    private void Update()
    {
        //Loops through the list of grids and sets them to true or false 
        for(int i = 0; i < plantingGrids.Count; i++)
        {
            if (hidden)
            {
                plantingGrids[i].SetActive(false);
            }

            else if (!hidden)
            {
                plantingGrids[i].SetActive(true);
            }
        }
    }


    // Sunflower Icon - Sets the value of the hidden bool which determines if the grids should be shown or not
    public void SeedMenu()
    {
        if (!hidden)
        {
            hidden = true;
            LeanTween.move(ui_Menu.GetComponent<RectTransform>(), new Vector3(0, -520f, 0), 1f).setDelay(0.1f).setOnComplete(ShowMe);
           
        }

        else if (hidden)
        {
            hidden = false;
            LeanTween.move(ui_Menu.GetComponent<RectTransform>(), new Vector3(0, 0, 0), 1f).setDelay(0.1f);
            sunflowerIcon.SetActive(false);
            zoomBar.SetActive(false);
            zoomIcon.SetActive(false);

        }
    }

    public void ShowMe()
    {
        sunflowerIcon.SetActive(true);
        zoomBar.SetActive(true);
        zoomIcon.SetActive(true);
    }

}
