using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Seed : MonoBehaviour
{
    public Seeds[] seeds;
    private List<GameObject> MenuItems;
    [SerializeField] private TMPro.TextMeshProUGUI flowerName, desc, flowerTime, fullSize, cost;
    public Color common, uncommon, rare, legendary;

    private void Start()
    { 
        MenuItems = new List<GameObject>();

        foreach(GameObject go in GameObject.FindGameObjectsWithTag("MenuIcons"))
        {
            MenuItems.Add(go);
        }
    }

    private void Update()
    {
        
    }

    public void Flower1()
    {
        flowerName.text = seeds[0].name;
        flowerName.color = seeds[0].rarity;
        desc.text = seeds[0].description;
        flowerTime.text = seeds[0].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[0].fullSize.ToString() + " cm";
        cost.text = seeds[0].cost.ToString() + " gp";
    }

    public void Flower2()
    {
        flowerName.text = seeds[1].name;
        flowerName.color = seeds[1].rarity;
        desc.text = seeds[1].description;
        flowerTime.text = seeds[1].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[1].fullSize.ToString() + " cm";
        cost.text = seeds[1].cost.ToString() + " gp";
    }

    public void Flower3()
    {
        flowerName.text = seeds[2].name;
        flowerName.color = seeds[2].rarity;
        desc.text = seeds[2].description;
        flowerTime.text = seeds[2].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[2].fullSize.ToString() + " cm";
        cost.text = seeds[2].cost.ToString() + " gp";
    }

    public void Flower4()
    {
        flowerName.text = seeds[3].name;
        flowerName.color = seeds[2].rarity;
        desc.text = seeds[3].description;
        flowerTime.text = seeds[3].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[3].fullSize.ToString() + " cm";
        cost.text = seeds[3].cost.ToString() + " gp";
    }

    public void Flower5()
    {
        flowerName.text = seeds[4].name;
        flowerName.color = seeds[4].rarity;
        desc.text = seeds[4].description;
        flowerTime.text = seeds[4].flowerPeriod.ToString() + " hours";
        fullSize.text = seeds[4].fullSize.ToString() + " cm";
        cost.text = seeds[4].cost.ToString() + " gp";
    }

}
