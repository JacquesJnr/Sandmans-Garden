using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTransition : MonoBehaviour
{
    private Camera cam;
    private Transform camTransform;
    private float camSize;
    public float targetSize;
    public Vector3 targetPosition;
    public float transitionSpeed;
    public Canvas canvas;
    public bool stopZooming;

    private PanZoom panZoom;
    private Highlight highlightScript;
    private CamMovementLimits camBounds;

    private void Start()
    {
        cam = Camera.main;
        camTransform = cam.gameObject.transform;
        camSize = cam.orthographicSize;
        canvas.enabled = false;
        panZoom = gameObject.GetComponent<PanZoom>();
        highlightScript = GameObject.FindObjectOfType<Highlight>();
        camBounds = GameObject.FindObjectOfType<CamMovementLimits>();
        panZoom.enabled = false;
        highlightScript.enabled = false;
        camBounds.enabled = false;
    }

    private void Update()
    {

        if(cam.orthographicSize == targetSize)
        {
            stopZooming = true;
        }

        if (!stopZooming)
        {
            if (Input.GetMouseButtonDown(0))
            {
                LeanTween.move(cam.gameObject, targetPosition, transitionSpeed).setOnComplete(EnablePan);
                zoomIn();
            }
        }
       
    }

    public void EnablePan()
    {
        panZoom.enabled = true;
        highlightScript.enabled = true;
        camBounds.enabled = true;
        canvas.enabled = true;
    }

    public void zoomIn()
    {
        LeanTween.value(cam.gameObject, cam.orthographicSize, targetSize, transitionSpeed).setOnUpdate((float flt) => {
            cam.orthographicSize = flt;
        });
    }
}
