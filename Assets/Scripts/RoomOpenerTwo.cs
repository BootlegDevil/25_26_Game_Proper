using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomOpenerTwo : MonoBehaviour
{
    public BoxCollider2D doorCollider;
    private int allButtons = 2;
    public int buttonAmount;
    public void OnButtonPressed()
    {
        buttonAmount += 1;
        if (buttonAmount == allButtons)
        {
            doorCollider.enabled = false;
        }
    }
    public void OnButtonUnpressed()
    {
        buttonAmount -= 1;
        if (buttonAmount != allButtons)
        {
            doorCollider.enabled = true;
        }
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
