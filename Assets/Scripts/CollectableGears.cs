using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class CollectableGears : MonoBehaviour
{
    private Collider2D playerIn = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        

        playerIn = collision;
    }
    private void Update()
    {
        if (playerIn == null) return;
        if (!Input.GetKeyDown(KeyCode.E))
        {
            return;
        }
        //TODO sent info to player
        PlayerInventory playerInventory = null;
        playerInventory = playerIn.gameObject.GetComponent<PlayerInventory>();

        if (playerInventory == null) return;
        playerInventory.Collect();
        Destroy(gameObject);

        playerIn = null;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        playerIn = null;
    }
}
