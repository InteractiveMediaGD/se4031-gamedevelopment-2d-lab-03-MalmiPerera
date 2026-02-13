using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab;

    void Update()
    {
        // 0 is the Left Mouse Button
        if (Input.GetMouseButtonDown(0))
        {
            // Create a copy of the projectile at the player's position
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}