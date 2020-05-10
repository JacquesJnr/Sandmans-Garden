using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Seed : MonoBehaviour
{
    public Seeds[] seeds;
    public Button one, two;

    private void Start()
    {
        seeds[0] = new Seeds("Daisy seed", "An adorable flower", 4f, 21, 10);
    }

    private void Update()
    {
        
    }

}
