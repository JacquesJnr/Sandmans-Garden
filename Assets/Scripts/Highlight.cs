using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    [SerializeField]private GameObject highlightedGrid;
    //[SerializeField]private Material gridColour;
    private List<GameObject> gridSqaures;
    public LayerMask whatIsGrids;
    public LayerMask whatIsPlots;
    public bool selected;
    public Color highlighted;
    public Color unhighlighted;

    private Ray ray;
    private RaycastHit hit;


    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, whatIsGrids))
        {
            highlightedGrid = hit.transform.gameObject;
            foreach (Renderer renderer in highlightedGrid.GetComponentsInChildren<Renderer>())
            {
                renderer.material.SetColor("_TintColor", highlighted);
            }

        }
        else
        {
            if(highlightedGrid != null)
            {
                foreach (Renderer renderer in highlightedGrid.GetComponentsInChildren<Renderer>())
                {
                    renderer.material.SetColor("_TintColor", unhighlighted);
                }
                highlightedGrid = null;
            }
           
        }

    }

    private void FixedUpdate()
    {
        if(highlightedGrid != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!selected)
                {
                    selected = true;
                    Debug.Log("Selected " + highlightedGrid.name);
                }
                else if(selected)
                {
                    selected = false;
                    Debug.Log("Deselected " + highlightedGrid.name);
                }
                else
                {
                    Debug.Log("There is no grid selected");
                }
            }
        }
      
    }

}
