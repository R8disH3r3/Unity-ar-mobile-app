using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public float rotationSpeed = 0.2f;

    void Update()
    {
        if (Input.touchCount == 1) // One finger touch
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                // Rotate around Y-axis based on finger movement
                float rotX = touch.deltaPosition.x * rotationSpeed;
                transform.Rotate(Vector3.up, -rotX, Space.World);
            }
        }
    }
}


