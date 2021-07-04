using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehaviour : MonoBehaviour
{
    public GameManager gameManager;
    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameManager.GotKey())
        {
            gameManager.UseKey();
            anim.SetBool(0, true);
        }
    }
}
