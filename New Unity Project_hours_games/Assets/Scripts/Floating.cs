using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public float rotationSpeed;
    public float FloatingSpeed;

    void Update()
    {
        Rotate();
        Float();
    }

    void Rotate()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
    }

    void Float()
    {
        transform.Translate(0, FloatingSpeed * Mathf.Cos(Time.time) * Time.deltaTime, 0);
    }
}
