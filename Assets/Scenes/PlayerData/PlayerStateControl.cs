using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateControl : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] Player player;
    public float movementSpeed;
    public bool isDead, isAerial, isMoving, isHurt;
    public float Health;
    private void Start() {
        movementSpeed = player.playerStats.MovementSpeed;
    }

    void Update()
    {
        if (movement.move.x != 0){
            isMoving = true;
        } else isMoving = false;
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("ground")) {
            isAerial = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("ground")) {
            isAerial = false;
        }
    }
    public void TakeDamage(float damage) {
        Health -= damage;
        //healthBar.value = Health;
        isHurt = true;
        if (Health <= 0) {
            isDead = true;
        }
        player.body.velocity = new Vector2(movement.move.x * -(movementSpeed/2), 4);
    }
}
