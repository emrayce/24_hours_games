using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = offset + target.position;
        transform.position = newPosition;
        transform.LookAt(target.position);
    }
}
