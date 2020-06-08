using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanZoom : MonoBehaviour
{
    public Camera cam;
    private Vector3 touchStart;
    public float zoomOutMin;
    public float zoomOutMax;
    float xpos;
    float zpos;

    public Slider zoomSlider;

    private void Start()
    {
        xpos = cam.transform.position.x;
        zpos = cam.transform.position.z;
    }

    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            touchStart = cam.ScreenToWorldPoint(Input.mousePosition);

        }
        if (Input.touchCount == 2){
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
            
        }

        zoom(Input.GetAxis("Mouse ScrollWheel") * 6f);
        zoomSlider.value = Camera.main.orthographicSize;
	}

    void zoom(float increment){
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}
