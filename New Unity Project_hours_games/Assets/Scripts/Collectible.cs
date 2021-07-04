using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    enum Pickable
    {
        Banana,
        Key
    }

    public GameManager gameManager;
   
    [SerializeField] private Pickable type;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (type == Pickable.Banana)
        {
            gameManager.BananaPicked();
        }
        else
        {
            gameManager.KeyPicked();
        }
    }
}
