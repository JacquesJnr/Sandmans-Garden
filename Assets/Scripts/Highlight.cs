using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private Material gridPiece;
    public LayerMask whatIsGrid;

    void FixedUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, whatIsGrid))
        {
            Color color;
            gridPiece = hit.transform.gameObject.GetComponent<Renderer>().material;
            color = hit.transform.gameObject.GetComponent<Renderer>().material.GetColor("_TintColor");
            gridPiece.SetColor("_TintColor", new Color(1f, 1f, 1f, 1f));
        }
        else
        {
            gridPiece.SetColor("_TintColor", new Color(0.46f, 1f, 0f, 1f));
        }
    }
}
