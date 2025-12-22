using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    public int damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        PlayerHealth healthPlayer = collision.gameObject.GetComponent<PlayerHealth>();

        if (healthPlayer == null)
        {
            return;
        }

        healthPlayer.TakeDamage(damage);
    }
}
