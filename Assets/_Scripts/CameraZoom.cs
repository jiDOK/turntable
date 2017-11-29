using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [Range(0f, 1f)]
    public float startPoint = 0.5f;
    [Range(0.3f, 1.35f)]
    public float zoomSpeed = 1f;
    public Transform nearTransform;
    public Transform farTransform;

    float zoomFactor;

    void Start()
    {
        zoomFactor = startPoint;
    }

    void Update()
    {
        float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
        if (scrollWheel != 0)
        {
            zoomFactor += scrollWheel * zoomSpeed;
            if (zoomFactor > 1f) { zoomFactor = 1f; }
            else if (zoomFactor < 0f) { zoomFactor = 0f; }
        }
        transform.position = Vector3.Lerp(farTransform.position, nearTransform.position, zoomFactor);
        transform.rotation = Quaternion.Lerp(farTransform.rotation, nearTransform.rotation, zoomFactor);
    }
}
