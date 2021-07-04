using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (gameManager.IsEverythingCollected())
        {
            gameManager.Victory();
        }
    }
}
