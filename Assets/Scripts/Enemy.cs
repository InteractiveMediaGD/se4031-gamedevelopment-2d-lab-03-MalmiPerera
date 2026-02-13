using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 20;

    void OnTriggerEnter2D(Collider2D other)
    {
        // 1. Check if hit by a Projectile
        if (other.CompareTag("Projectile"))
        {
            // Find the ScoreManager in the scene and add 5 points
            // (Note: This assumes you have a ScoreManager object from Lab 01)
            FindObjectOfType<ScoreManager>().AddScore(5);
            
            // Destroy the bullet (other) and the enemy (this)
            Destroy(other.gameObject);
            Destroy(gameObject);
            return; // Stop here so we don't do damage logic below
        }

        // 2. Check if hit by the Player
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Clean up: If this object goes too far left, delete it
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}