using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehaviour : MonoBehaviour
{
    public GameManager gameManager;
    private Animator anim;
    private BoxCollider[] physicalCollider;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        physicalCollider = gameObject.GetComponents<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameManager.GotKey())
        {
            gameManager.UseKey();
            anim.SetBool("Open", true);
            DisableCollider();
        }
    }

    private void DisableCollider()
    {
        foreach (BoxCollider i in physicalCollider)
        {
            if (!i.isTrigger)
            {
                i.enabled = false;
            }
        }
    }
}
