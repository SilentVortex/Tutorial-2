using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100.0f;
    public float currentHealth = 100.0f;
    public GameObject deathScreen;
    public GameObject gameUI;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        // Checks if the player's health is 0, if so then call the die method below
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
{
    // Deactivate the player object
    gameObject.SetActive(false);
    // Deactivate the UI
    gameUI.SetActive(false);
    //stop time, literally
    Time.timeScale = 0f;
    // Activate the death screen object
    deathScreen.SetActive(true);
}

}
