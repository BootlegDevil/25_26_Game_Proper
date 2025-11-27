using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int numberCollectible;
    public TextMeshProUGUI textCollectible;
    public void Collect()
    {
        numberCollectible++;
        textCollectible.text = numberCollectible.ToString();
    }
}
