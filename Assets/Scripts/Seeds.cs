using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Seeds
{
    public string name;
    public Color rarity;
    public string description;
    public float flowerPeriod;
    public float fullSize;
    public int cost;
    public Texture img;

    public Seeds(string name, Color rarity, string description, float flowerPeriod, float fullSize, int cost, Texture img)
    {
        this.name = name;
        this.rarity = rarity;
        this.description = description;
        this.flowerPeriod = flowerPeriod;
        this.fullSize = fullSize;
        this.cost = cost;
        this.img = img;
    }

}
