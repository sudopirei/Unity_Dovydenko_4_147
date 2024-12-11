using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour
{
    private float Health;
    [SerializeField] PlayerStateControl PlayerHealth;
    // Start is called before the first frame update
    void Start()
    {
        Health = 80;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")) {
            PlayerHealth.TakeDamage(20);
            Health -= 20;
            if (Health <= 0) {
                Destroy(gameObject);
            }
        }
    }
}
