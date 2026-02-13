using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healAmount = 20;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object we hit has the 'PlayerHealth' script
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            // Increase health but don't go over 100 (Mathf.Min does this)
            player.currentHealth = Mathf.Min(player.currentHealth + healAmount, player.maxHealth);
            
            // Tell the player script to refresh the screen text
            player.SendMessage("UpdateUI");
            
            // Remove this Health Pack from the game
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Clean up: If this object drifts too far left, delete it
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}