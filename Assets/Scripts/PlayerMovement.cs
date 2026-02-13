using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private float timer = 0f; // Track how long we have been playing

    void Update()
    {
        // Count up time
        timer += Time.deltaTime;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(x, y);

        // Calculate new speed: Base speed + (Time * 0.3)
        // Example: After 10 seconds, speed adds +3
        float currentSpeed = speed + (timer * 0.3f);

        transform.Translate(move * currentSpeed * Time.deltaTime);
    }
}