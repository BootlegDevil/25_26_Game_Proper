using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeverFlicker : MonoBehaviour
{
    private Collider2D playerIn = null;
    public bool isFlicked;
    public RoomOpenerOne roomOpenerOne;
    public int order;
    public void OnPuzzleWrong()
    {
        isFlicked = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        playerIn = collision;
    }
    void Update()
    {
        if (playerIn == null) return;
        if (Input.GetKeyDown(KeyCode.E) && !isFlicked)
        {
            isFlicked = true;
            roomOpenerOne.OnLeverFlicked(order);
            return;
        }
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
