using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovementLimits : MonoBehaviour
{
    //mapX, mapY is size of background image
    private float mapX = 100f;
    private float mapY = 80f;
    private float mapZ = 50f;
    private float minX, maxX;
    private float minY, maxY;
    private float minZ, maxZ;

    private float vertExtent;
    private float horzExtent;

    void Update()
    {
        vertExtent = Camera.main.orthographicSize;
        horzExtent = vertExtent * Screen.width / Screen.height;

        // Calculations assume map is position at the origin
        minX = horzExtent - mapX / 2.0f;
        maxX = mapX / 3f - horzExtent;
        minY = vertExtent - mapY / 2.0f;
        maxY = mapY / 2.0f - vertExtent;
        minZ = horzExtent - mapZ / 2.0f;
        maxZ = mapZ / 2.0f - mapZ / 2.0f;
    }

    void LateUpdate()
    {
        Vector3 v3 = Camera.main.transform.position;
        v3.x = Mathf.Clamp(v3.x, minX, maxX);
        v3.y = Mathf.Clamp(v3.y, minY, maxY);
        v3.z = Mathf.Clamp(v3.z, minZ, maxZ);
        Camera.main.transform.position = v3;
    }
}
