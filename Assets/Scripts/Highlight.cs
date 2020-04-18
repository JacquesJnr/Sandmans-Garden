﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public GameObject highlightedGrid, gridToPlant;
    public GameObject prevHighlighted; // set private if works
    public LayerMask whatIsGrids;
    //public LayerMask whatIsPlots; // For later
    public bool selected;
    public Color highlighted;
    public Color unhighlighted;

    private Ray ray;
    private RaycastHit hit;

    public GameObject chevron;
    public Transform chevronOrigin;

    private UIManager _ui;

    private void Start()
    {
        chevron.transform.position = chevronOrigin.position;
        _ui = FindObjectOfType<UIManager>();
    }

    private void FixedUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (highlightedGrid != null)
        {
            prevHighlighted = highlightedGrid;
        }

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
            if (highlightedGrid != null)
            {
                foreach (Renderer renderer in highlightedGrid.GetComponentsInChildren<Renderer>())
                {
                    renderer.material.SetColor("_TintColor", unhighlighted);
                }

                highlightedGrid = null;
            }

        }

        if (!_ui.hideGrid)
        {
            chevron.SetActive(true);

            if (highlightedGrid != null)
            {
                chevron.transform.position = highlightedGrid.transform.position + new Vector3(0, 3, 0);
                chevron.GetComponent<ChevronFloat>().enabled = true;
            }
        }
        else if(_ui.hideGrid && highlightedGrid != null)
        {
            
        }
        else
        {
            chevron.SetActive(false);
        }

        if (highlightedGrid != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!selected)
                {
                    selected = true;
                    gridToPlant = highlightedGrid;
                    Debug.Log("Selected " + highlightedGrid.name);
                }
                else if (selected)
                {
                    selected = false;
                    gridToPlant = null;
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
