using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // Reference to the bullet prefab
    public Transform shootingPoint;  // The point from where the bullet is spawned

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Typically left mouse button or Ctrl
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate the bullet at the shooting point's position and rotation
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);

        // Set the bullet's direction to only go along the x-axis
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        if (bulletScript != null)
        {
            // Assuming shooting right
            bulletScript.SetDirection(Vector3.right); // Change to Vector3.left for shooting left
        }
    }
}

