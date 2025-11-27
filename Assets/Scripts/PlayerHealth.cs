using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealthPlayer = 3;
    [SerializeField] private float healthPlayer = 3;
    public TextMeshProUGUI textHealthPlayer;

    private void Start()
    {
        textHealthPlayer.text = healthPlayer.ToString();
    }

    public bool isDead = false;

    public void TakeDamage(float damage)
    {
        healthPlayer = healthPlayer - damage;
        if (healthPlayer < 0)
        {
            healthPlayer = 0;
        }
        if (healthPlayer > maxHealthPlayer)
        {
            healthPlayer = maxHealthPlayer;
        }
        if (healthPlayer == 0)
        {
            isDead = true;
            Invoke(nameof(ReloadScene), 2);
        }
        textHealthPlayer.text = healthPlayer.ToString();
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
