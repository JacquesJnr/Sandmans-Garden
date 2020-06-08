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
    public RawImage myImage, smallImage;
    [SerializeField] private TMPro.TextMeshProUGUI flowerName, flowerTime, fullSize, cost, scrollText;
    public TMPro.TMP_InputField scrollWindow;
    public Color common, uncommon, rare, legendary;

    private void Start()
    { 
        MenuItems = new List<GameObject>();
        smallImage.enabled = false;

        foreach(GameObject go in GameObject.FindGameObjectsWithTag("MenuIcons"))
        {
            MenuItems.Add(go);
        }
    }

    public void Flower1() //Wrapvine
    {
        smallImage.enabled = true;
        myImage.enabled = false;
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
        myImage.enabled = true;
        smallImage.enabled = false;
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
        myImage.enabled = true;
        smallImage.enabled = false;
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
        myImage.enabled = true;
        smallImage.enabled = false;
        flowerName.text = seeds[3].name;
        flowerName.color = seeds[2].rarity;
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
        myImage.enabled = true;
        smallImage.enabled = false;
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

}
