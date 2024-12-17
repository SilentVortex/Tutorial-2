
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float maxHealth = 100.0f;
    public float currentHealth = 100.0f;
    public GameObject deathScreen;
    public GameObject gameUI;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        gameObject.SetActive(false);
        gameUI.SetActive(false);
        Time.timeScale = 0f;
        deathScreen.SetActive(true);
    }

}
