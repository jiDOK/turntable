using UnityEngine;

public class Turntable : MonoBehaviour
{
    public float mouseSensitivity = 15f;
    public float rotationSpeed = 10f;
    bool rotatingByMouse = false;

    void Update()
    {
        if (!rotatingByMouse)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);
        }
    }

    void OnMouseDrag()
    {
        if (!rotatingByMouse) { rotatingByMouse = true; }
        transform.Rotate(0, (-Input.GetAxis("Mouse X")) * mouseSensitivity * Time.deltaTime * 10, 0, Space.World);
    }

    void OnMouseUp()
    {
        rotatingByMouse = false;
    }
}
