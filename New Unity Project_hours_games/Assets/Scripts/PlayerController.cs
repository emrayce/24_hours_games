using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 acceleration = Vector3.zero;

        if (Input.GetKey(KeyCode.Z))
        {
            acceleration += speed * Vector3.forward;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            acceleration += speed * Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            acceleration += speed * Vector3.right;
        }

        if (Input.GetKey(KeyCode.S))
        {
            acceleration += speed * Vector3.back;
        }

        _rb.AddForce(acceleration, ForceMode.Acceleration);
    }
}
