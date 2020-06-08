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

    private GameObject ui_Menu, infoWindow, sunflowerIcon, zoomBar, zoomIcon, tripleBar, flowerImg, tripleBarWindow, analysisStats, sideTabCloseIcon, points, soundWindow; //Canvas items
    public GameObject optionsPage, plantingPage, background;
    [SerializeField] private Texture infoImage;
    public RectTransform hiddenPosition, visiblePosition;
    public bool selectingSeed, gardening, optionSelect, sandmansRecords;
    public bool planting;
    public TMPro.TextMeshProUGUI helpText;
    private Highlight highlightScript; // References Highlight.cs
    private PanZoom _panZoom;

    private List<GameObject> tabMenuOrder;
    public AnimationCurve curve;


    private void Start()
    {
        ui_Menu = GameObject.Find("GardeningMenu");
        sunflowerIcon = GameObject.Find("GardeningIcon");
        zoomBar = GameObject.Find("Zoom Bar");
        zoomIcon = GameObject.Find("ZoomIcon");
        tripleBar = GameObject.Find("MenuIcon");
        tripleBarWindow = GameObject.Find("Side Tab");
        infoWindow = GameObject.Find("SeedWindow");
        flowerImg = GameObject.Find("Image");
        optionsPage = GameObject.Find("Options");
        analysisStats = GameObject.Find("Records Stats");
        sideTabCloseIcon = GameObject.Find("SideTabX");
        points = GameObject.Find("Points");
        soundWindow = GameObject.Find("Audio Window");

        tabMenuOrder = new List<GameObject>();

        highlightScript = FindObjectOfType<Highlight>();
        _panZoom = FindObjectOfType<PanZoom>();

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


        if (gardening)
        {
            infoWindow.SetActive(true);
            sunflowerIcon.SetActive(false);
            zoomBar.SetActive(false);
            zoomIcon.SetActive(false);
        }
        else
        {
            planting = false;
            hideGrid = true;
            selectingSeed = false;
            highlightScript.highlightedGrid = null;
            highlightScript.gridToPlant = null;
            infoWindow.SetActive(false);
            zoomBar.SetActive(true);
            zoomIcon.SetActive(true);
            MoveDown(plantingPage);
        }

        if (optionSelect)
        {
            if (IsMouseOverUI())
            {
                _panZoom.enabled = false;
            }
        }

        if (analysisStats.GetComponent<RawImage>().color.a == 1)
        {
            _panZoom.enabled = false;
        }

        if (soundWindow.GetComponent<RectTransform>().anchoredPosition == new Vector2(-55, -262))
        {
            _panZoom.enabled = false;
        }

    }

    // Sunflower Icon - Sets the value of the hideGrid bool which determines if the grids should be shown or not
    public void SeedMenu()
    {
        if(!gardening)
        {
            gardening = true;
            LeanTween.move(ui_Menu.GetComponent<RectTransform>(), new Vector3(0, 0, 0), 0.5f).setEase(curve);
        }

        else if (gardening)
        {
            gardening = false;
            sunflowerIcon.SetActive(true);
            LeanTween.move(ui_Menu.GetComponent<RectTransform>(), new Vector3(0, -520f, 0), 0.5f).setEase(curve);
        }
    }

    public void CloseGardeningWindow()
    {
        LeanTween.move(optionsPage.GetComponent<RectTransform>(), new Vector3(-26, 0, 0), 0.1f).setEase(curve);
        
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

    public void SideTab()
    {
        if (!optionSelect)
        {
            optionSelect = true;
            sunflowerIcon.SetActive(false);
            points.SetActive(false);
            LeanTween.alpha(background.GetComponent<RectTransform>(), 0.82f, 0.5f);
        }

        else if (optionSelect)
        {
            optionSelect = false;
            sunflowerIcon.SetActive(true);
            points.SetActive(true);
            LeanTween.alpha(background.GetComponent<RectTransform>(), 0f, 0.5f);
        }
    }

    public void SandmansRecords()
    {
        optionSelect = false;
        tripleBar.SetActive(false);
        sunflowerIcon.SetActive(false);
        analysisStats.SetActive(true);
        LeanTween.alpha(analysisStats.GetComponent<RectTransform>(), 1, 0.8f);
        LeanTween.alpha(sideTabCloseIcon.GetComponent<RectTransform>(), 1, 0.8f);
    }

    public void Audio()
    {
        optionSelect = false;
        tripleBar.SetActive(false);
        sunflowerIcon.SetActive(false);
        analysisStats.SetActive(false);
        LeanTween.move(soundWindow.GetComponent<RectTransform>(), new Vector3(-55, -262, 0), 0.8f).setEase(curve);
        LeanTween.alpha(sideTabCloseIcon.GetComponent<RectTransform>(), 1, 0.8f);
    }


    public void closeTabChild()
    {
        if (!optionSelect)
        {
            LeanTween.alpha(analysisStats.GetComponent<RectTransform>(), 0, 0.1f);
            LeanTween.alpha(sideTabCloseIcon.GetComponent<RectTransform>(), 0, 0.1f);
            LeanTween.move(soundWindow.GetComponent<RectTransform>(), new Vector3(-55, 1173, 0), 0.8f).setEase(curve);
            tripleBar.SetActive(true);
            optionSelect = true;
        }
    }

    public void MoveDown(GameObject ui_element)
    {
        LeanTween.move(ui_element.GetComponent<RectTransform>(), new Vector3(-55, -664, 0), 0.1f);
    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }

    private void OnGUI()
    {
        if (planting)
        {
            LeanTween.move(plantingPage.GetComponent<RectTransform>(), new Vector3(-22, 23, 0), 0.2f).setEase(curve);
        }

        if (optionSelect)
        {
            LeanTween.move(tripleBarWindow.GetComponent<RectTransform>(), new Vector3(-705, 149, 0), 0.2f).setEase(curve);
           
        }
        else
        {
            LeanTween.move(tripleBarWindow.GetComponent<RectTransform>(), new Vector3(-1365, 149, 0), 0.2f).setEase(curve);
        }
    }

}
