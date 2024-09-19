using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f; // Speed of the bullet
    public float damage = 10f; // Damage dealt by the bullet
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Initialize the Rigidbody component
    }

    public void SetDirection(Vector3 direction)
    {
        // Only allow movement along the x-axis
        rb.velocity = new Vector3(direction.x * speed, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage); // Deal damage to the enemy
            }
            Destroy(gameObject); // Destroy bullet on collision
        }
    }
}
