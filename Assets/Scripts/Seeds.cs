using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Seeds
{
    public string name;
    public string description;
    public float flowerPeriod;
    public float fullSize;
    public int cost;

    public Seeds(string name, string description, float flowerPeriod, float fullSize, int cost)
    {
        this.name = name;
        this.description = description;
        this.flowerPeriod = flowerPeriod;
        this.fullSize = fullSize;
        this.cost = cost;
    }

}
