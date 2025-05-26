using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        { return; } 
        inventory Inventory = collision.gameObject.GetComponent<inventory >();
        Destroy(gameObject);
    }

   
}
