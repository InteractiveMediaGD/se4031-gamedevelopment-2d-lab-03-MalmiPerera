using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // Automatically delete the bullet after 2 seconds so it doesn't float forever
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        // Move to the right
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}