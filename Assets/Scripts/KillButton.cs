using UnityEngine;

public class KillButton : MonoBehaviour
{
    // Sets what I want to be able to be changed //
    public Transform player;
    public float attackDamage = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {

    }

    public void Damage()
    {
        // Code to handle the attack, such as damaging the player
        player.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
    }
}
