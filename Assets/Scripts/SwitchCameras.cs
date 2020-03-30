using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public GameObject startCam, gameCam;

    private void Start()
    {
        startCam.SetActive(true);
        //gameCam.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }
}
