using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Vector3 direction;
    // It needs A LOT of POWER
    public float power;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("hi");
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(direction * power, ForceMode.Impulse);
        }
    }
}
