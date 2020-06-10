using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Seed : MonoBehaviour
{
    public Seeds[] seeds;
    private List<GameObject> MenuItems;
    public Texture budpodColour, espadaColour, peacockColour, peelerColour, polyvaseColor, sailColour, wrapvineColour;
    public GameObject wrapvinePrefab, peacockPrefab, sailPrefab, espadaPrefab;
    public RawImage myImage, smallImage;
    [SerializeField] private TMPro.TextMeshProUGUI flowerName, flowerTime, fullSize, cost, scrollText;
    public TMPro.TMP_InputField scrollWindow;
    public Color common, uncommon, rare, legendary;
    public bool goToMouse, goToMouse_s;
    public RawImage mouseIcon, mouseIconSmall;
  

    private UIManager _ui;

    private void Start()
    { 
        MenuItems = new List<GameObject>();
        smallImage.gameObject.SetActive(false);
        _ui = FindObjectOfType<UIManager>();

        foreach(GameObject go in GameObject.FindGameObjectsWithTag("MenuIcons"))
        {
            MenuItems.Add(go);
        }
    }

    public void Flower1() //Wrapvine
    {
        myImage.gameObject.SetActive(false);
        smallImage.gameObject.SetActive(true);
        scrollWindow.text = seeds[0].description;
        flowerName.text = seeds[0].name;
        flowerName.color = seeds[0].rarity;
        scrollWindow.text = seeds[0].description;
        flowerTime.text = seeds[0].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[0].fullSize.ToString() + " cm";
        cost.text = seeds[0].cost.ToString() + " gp";
        smallImage.texture = wrapvineColour;
    }

    public void Flower2() //Polyvase
    {
        myImage.gameObject.SetActive(true);
        smallImage.gameObject.SetActive(false);
        flowerName.text = seeds[1].name;
        flowerName.color = seeds[1].rarity;
        scrollWindow.text = seeds[1].description;
        flowerTime.text = seeds[1].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[1].fullSize.ToString() + " cm";
        cost.text = seeds[1].cost.ToString() + " gp";
        myImage.texture = polyvaseColor;
    }

    public void Flower3() //Peacock
    {
        myImage.gameObject.SetActive(true);
        smallImage.gameObject.SetActive(false);
        flowerName.text = seeds[2].name;
        flowerName.color = seeds[2].rarity;
        scrollWindow.text = seeds[2].description;
        flowerTime.text = seeds[2].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[2].fullSize.ToString() + " cm";
        cost.text = seeds[2].cost.ToString() + " gp";
        myImage.texture = peacockColour;
    }

    public void Flower4() //Sail
    {
        myImage.gameObject.SetActive(true);
        smallImage.gameObject.SetActive(false);
        flowerName.text = seeds[3].name;
        flowerName.color = seeds[3].rarity;
        scrollWindow.text = seeds[3].description;
        flowerTime.text = seeds[3].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[3].fullSize.ToString() + " cm";
        cost.text = seeds[3].cost.ToString() + " gp";
        myImage.texture = sailColour;
        float imageSizeX = myImage.GetComponent<RectTransform>().sizeDelta.x;
        float imageSizeY = myImage.GetComponent<RectTransform>().sizeDelta.y;
        imageSizeX = 62;
        imageSizeY = 210;
    }

    public void Flower5() //Espada Sol
    {
        myImage.gameObject.SetActive(true);
        smallImage.gameObject.SetActive(false);
        flowerName.text = seeds[4].name;
        flowerName.color = seeds[4].rarity;
        scrollWindow.text = seeds[4].description;
        flowerTime.text = seeds[4].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[4].fullSize.ToString() + " cm";
        cost.text = seeds[4].cost.ToString() + " gp";
        myImage.texture = espadaColour;

        //Vector2 dimensions = new Vector2(95, 330);
        //myImage.gameObject.GetComponent<RectTransform>().sizeDelta = dimensions;
        //myImage.gameObject.GetComponent<Transform>().localPosition = new Vector3(250, -20 , 0);
    }

    public void GetIcon()
    {
        if (!goToMouse)
        {
            goToMouse = true;
            mouseIcon.texture = myImage.texture;
            Cursor.visible = false;
        }
    }

    public void GetSmallerIcon()
    {
        if (!goToMouse_s)
        {
            goToMouse_s = true;
            goToMouse = false;
            mouseIconSmall.texture = smallImage.texture;
            Cursor.visible = false;
        }
    }

    public void SpawnFlower(GameObject plot)
    {
        //if (smallImage.texture = wrapvineColour)
        //    Object.Instantiate(wrapvinePrefab, plot.transform.position, Quaternion.identity);
        //{
        //    Debug.Log("Wrapvine");
        //}

        if (myImage.texture == peacockColour)
        {
            Debug.Log("Peacock");
            Object.Instantiate(peacockPrefab, plot.transform.position, Quaternion.identity);
        }

        if (myImage.texture == sailColour)
        {
            Debug.Log("Sail");
            Object.Instantiate(sailPrefab, plot.transform.position + new Vector3(0, 1.2f, 0), Quaternion.identity);
        }

        if (myImage.texture == espadaColour)
        {
            Debug.Log("Espada");
            Object.Instantiate(espadaPrefab, plot.transform.position, Quaternion.identity);
        }

    }
}
