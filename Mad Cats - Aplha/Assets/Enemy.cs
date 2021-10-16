using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _smokeParticlePrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool didHitCat = collision.collider.GetComponent<Cat>() != null;
        if (didHitCat)
        {
            Instantiate(_smokeParticlePrefab, transform.position, Quaternion.identity); //particle, hely, default position
            Destroy(gameObject);
            return;
        }

        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            return;
        }

        if(collision.contacts[0].normal.y < -0.5)
        {
            Instantiate(_smokeParticlePrefab, transform.position, Quaternion.identity); //particle, hely, default position
            Destroy(gameObject);
        }
    }
}
