using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> plantingGrids;
    //[SerializeField] private List<GameObject> gardeningBoxes;
    [SerializeField] private List<GameObject> seedMenuBoxes;
    [SerializeField] private List<RawImage> menuItems;
    public bool hideGrid = true;
    private int iconToHighlight;

    private GameObject ui_Menu, infoWindow, sunflowerIcon, zoomBar, zoomIcon, settings, flowerImg, settingsWindow; //Canvas items
    public GameObject optionsPage, plantingPage, background;
    [SerializeField] private Texture infoImage;
    public RectTransform hiddenPosition, visiblePosition;
    public bool selectingSeed, gardening, optionSelect;
    public bool planting;
    public TMPro.TextMeshProUGUI helpText;

    [SerializeField] private List<GameObject> flowerPrefabs;
    private Vector3 mouse;

    private Highlight highlightScript; // References Highlight.cs
    private PanZoom _panZoom;
    private Seed _seed;
    

    private void Start()
    {
        ui_Menu = GameObject.Find("GardeningMenu");
        sunflowerIcon = GameObject.Find("GardeningIcon");
        zoomBar = GameObject.Find("Zoom Bar");
        zoomIcon = GameObject.Find("ZoomIcon");
        settings = GameObject.Find("MenuIcon");
        settingsWindow = GameObject.Find("Options Window");
        infoWindow = GameObject.Find("SeedWindow");
        flowerImg = GameObject.Find("Image");
        optionsPage = GameObject.Find("Options");

        flowerPrefabs = new List<GameObject>();
        

        highlightScript = FindObjectOfType<Highlight>();
        _panZoom = FindObjectOfType<PanZoom>();
        _seed = FindObjectOfType<Seed>();

        //Finds all planting grids in the scene and adds them to the list plantingGrids
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("PlantingGrid"))
        {
            plantingGrids.Add(go);
        }       

        foreach(GameObject slot in GameObject.FindGameObjectsWithTag("seedMenuIcon"))
        {
            seedMenuBoxes.Add(slot);
            slot.GetComponent<Button>().interactable = false;
        }

        foreach(GameObject seedParent in GameObject.FindGameObjectsWithTag("SeedIcon"))
        {
            RawImage seeds = seedParent.GetComponent<RawImage>();
            menuItems.Add(seeds);
            flowerPrefabs.Add(seedParent);
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

            mouse = new Vector3(Input.GetAxis("Mouse X"), 0, 0);
        }

        //Checks the Highlight script to see whether or not the seed menu is interactable
        for (int i = 0; i < seedMenuBoxes.Count; i++)
        {
          if (planting)
          {
                //If a planting space is selected, allow the player to interact with the seed menu boxes
                if (!highlightScript.selected)
                {
                    seedMenuBoxes[i].GetComponent<Button>().interactable = false;
                }
                else
                {
                    seedMenuBoxes[i].GetComponent<Button>().interactable = true;
                }

                if (!seedMenuBoxes[i].GetComponent<Button>().interactable)
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
            else
            {
                helpText.text = "Choose an option:";
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

        if (!gardening)
        {
            planting = false;
            hideGrid = true;
            selectingSeed = false;
            highlightScript.highlightedGrid = null;
            highlightScript.gridToPlant = null;
            LeanTween.move(ui_Menu.GetComponent<RectTransform>(), new Vector3(0, -520f, 0), 0.5f).setOnComplete(CloseGardeningWindow);
            Position0();
        }

        if (gardening)
        {
            LeanTween.move(ui_Menu.GetComponent<RectTransform>(), new Vector3(0, 0, 0), 0.5f);
            infoWindow.SetActive(true);
            sunflowerIcon.SetActive(false);
            zoomBar.SetActive(false);
            zoomIcon.SetActive(false);

            if (!selectingSeed)
            {
                Position0();
            }
        }

       
    }

    // Sunflower Icon - Sets the value of the hideGrid bool which determines if the grids should be shown or not
    public void SeedMenu()
    {
        if(!gardening)
        {
            gardening = true;
        }

        else if (gardening)
        {
            gardening = false;
        }
    }

    public void CloseGardeningWindow()
    {
        sunflowerIcon.SetActive(true);
        highlightScript.selected = false;
        zoomBar.SetActive(true);
        zoomIcon.SetActive(true);
        LeanTween.move(optionsPage.GetComponent<RectTransform>(), new Vector3(-26, 0, 0), 0.1f);
        MoveDown(plantingPage);
    }

    public void PlantingWindow()
    {
        planting = true;
        MoveDown(optionsPage);
        plantingPage.SetActive(true);

        if (hideGrid)
        {
            hideGrid = false;
            infoWindow.SetActive(true);
        }

        else if (!hideGrid)
        {
            hideGrid = true;
            highlightScript.highlightedGrid = null;
            highlightScript.gridToPlant = null;
            infoWindow.SetActive(false);
        }
    }

    public void Position0()
    {
        infoWindow.transform.position = hiddenPosition.position;
    }
    public void Position1()
    {
        if (selectingSeed)
        {
            infoWindow.transform.position = visiblePosition.position;
        }
    }

    public void SideTab()
    {
        if (!optionSelect)
        {
            optionSelect = true;
            LeanTween.alpha(background.GetComponent<RectTransform>(), 0.82f, 0.5f);
        }

        else if (optionSelect)
        {
            optionSelect = false;
            LeanTween.alpha(background.GetComponent<RectTransform>(), 0f, 0.5f);
        }
    }

    public void IconToMouse()
    {
        _seed.mouseIcon.transform.position = Camera.main.ScreenToWorldPoint(mouse);
    }

    public void MoveDown(GameObject ui_element)
    {
        LeanTween.move(ui_element.GetComponent<RectTransform>(), new Vector3(-22, -664, 0), 0.1f);
    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }

    private void OnGUI()
    {
        if (planting)
        {
            LeanTween.move(plantingPage.GetComponent<RectTransform>(), new Vector3(-22,23,0), 0.2f);
        }

        if (optionSelect)
        {
            LeanTween.move(settingsWindow.GetComponent<RectTransform>(), new Vector3(-705, 149, 0), 0.3f);
            if (IsMouseOverUI())
            {
                _panZoom.enabled = false;
            }
        }
        else
        {
            LeanTween.move(settingsWindow.GetComponent<RectTransform>(), new Vector3(-1365, 149, 0), 0.3f);
        }
    }

}
