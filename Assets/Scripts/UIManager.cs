using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> plantingGrids;
    [SerializeField] private List<GameObject> menuBoxes;
    [SerializeField] private List<RawImage> menuItems;
    public bool hideGrid = true;
    private int iconToHighlight;

    private GameObject ui_Menu, infoWindow, sunflowerIcon, zoomBar, zoomIcon, settings, flowerImg; //Canvas items
    [SerializeField] private Texture infoImage;
    public RectTransform hiddenPosition, visiblePosition;
    private bool selectingSeed;
    public TMPro.TextMeshProUGUI helpText;
    private Highlight highlightScript; // References Highlight.cs
    private PanZoom _panZoom;

    

    private void Start()
    {
        ui_Menu = GameObject.Find("SeedMenu");
        sunflowerIcon = GameObject.Find("PlantingIcon");
        zoomBar = GameObject.Find("Zoom Bar");
        zoomIcon = GameObject.Find("ZoomIcon");
        settings = GameObject.Find("MenuIcon");
        infoWindow = GameObject.Find("SeedWindow");
        flowerImg = GameObject.Find("Image");
        //infoImage = flowerImg.GetComponent<RawImage>().texture;


        highlightScript = FindObjectOfType<Highlight>();
        _panZoom = FindObjectOfType<PanZoom>();

        //Finds all planting grids in the scene and adds them to the list plantingGrids
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("PlantingGrid"))
        {
            plantingGrids.Add(go);
        }       

        foreach(GameObject slot in GameObject.FindGameObjectsWithTag("MenuIcons"))
        {
            menuBoxes.Add(slot);
            slot.GetComponent<Button>().interactable = false;
        }

        foreach(GameObject seedParent in GameObject.FindGameObjectsWithTag("SeedIcon"))
        {
            RawImage seeds = seedParent.GetComponent<RawImage>();
            menuItems.Add(seeds);
            seeds.color = new Color(0.5f,0.5f,0.5f,255);
        }

    }

    private void Update()
    {
        //Loops through the list of grids and sets them to true or false depending on the state of the hideGrid bool
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

        //Checks the Highlight script to see whether or not the seed menu is interactable
        for (int i = 0; i < menuBoxes.Count; i++)
        {
            //If a planting space is selected, allow the player to interact with the seed menu boxes
            if (!highlightScript.selected)
            {
               
                menuBoxes[i].GetComponent<Button>().interactable = false;
            }
            else
            {
                menuBoxes[i].GetComponent<Button>().interactable = true;
                
            }

            if (!menuBoxes[i].GetComponent<Button>().interactable)
            {
                helpText.text = "Select a space to plant your flower";
                selectingSeed = false; //Used to determine if the seeds should be interactable
            }
            else
            {
                selectingSeed = true;
                helpText.text = "Select a seed to plant";
            }
        }

        if (selectingSeed)
        {
            for(int j = 0; j < menuItems.Count; j++)
            {
                menuItems[j].color = new Color(255, 255, 255, 255);
            }

            _panZoom.enabled = false;
        }
        else
        {
            for (int j = 0; j < menuItems.Count; j++)
            {
                menuItems[j].color = new Color(0.5f, 0.5f, 0.5f, 255);
            }

            _panZoom.enabled = true;
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
            infoWindow.SetActive(true);
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

    public void Position0()
    {
        if (selectingSeed)
        {
            infoWindow.transform.position = hiddenPosition.position;
        }
    }
    public void Position1()
    {
        if (selectingSeed)
        {
            infoWindow.transform.position = visiblePosition.position;

        }
    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }

}
