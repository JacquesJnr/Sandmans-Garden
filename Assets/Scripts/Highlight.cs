using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    public Material myMaterial;
    
    

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            print(hit.collider.name);
            Color color;
            color = myMaterial.GetColor("_TintColor");
            myMaterial.SetColor("_TintColor", new Color(1f, 1f, 1f, 1f));
        }
        else
        {
            myMaterial.SetColor("_TintColor", new Color(0.46f, 1f, 0f, 1f));
        }
            
    }
}
