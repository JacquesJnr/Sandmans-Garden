﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanZoom : MonoBehaviour
{
    public Camera cam;
    private Vector3 touchStart;
    public float zoomOutMin;
    public float zoomOutMax;
    public float min_x, max_x;
    public float min_y, max_y;
    public float min_z, max_z;

    public Slider zoomSlider;

    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0)){
            touchStart = cam.ScreenToWorldPoint(Input.mousePosition);

        }
        if(Input.touchCount == 2){
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            zoom(difference * 0.01f);
        }
        else if(Input.GetMouseButton(0))
        {
            Vector3 direction = touchStart - cam.ScreenToWorldPoint(Input.mousePosition);
            cam.transform.position += direction;

            float xpos = cam.transform.position.x;
            
        }

        zoom(Input.GetAxis("Mouse ScrollWheel") * 4f);
        zoomSlider.value = Camera.main.orthographicSize;
	}

    void zoom(float increment){
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}
