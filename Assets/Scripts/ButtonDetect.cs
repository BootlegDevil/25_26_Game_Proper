using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDetect : MonoBehaviour
{
    public bool isClicked;
    public RoomOpenerTwo roomOpenerTwo;
    public int buttonAmount;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (isClicked == false)
        {
            isClicked = true;
            roomOpenerTwo.OnButtonPressed();
        }
        return;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (isClicked == true)
        {
            isClicked = false;
            roomOpenerTwo.OnButtonUnpressed();
        }
        return;
    }
    void Update()
    {

    }
}
