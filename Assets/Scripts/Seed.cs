using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    public Seeds[] seeds;

    private void Start()
    {
        seeds[0] = new Seeds("Daisy seed", "An adorable flower", 4f, 21, 10);
    }
}
