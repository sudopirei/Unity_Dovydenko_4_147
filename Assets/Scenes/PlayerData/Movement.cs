using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] PlayerStateControl state;
    public Vector2 move;

    private void FixedUpdate () {
        if (!state.isDead) {
            move = new Vector2 (Input.GetAxisRaw("Horizontal"), 0);
            transform.Translate(state.movementSpeed * Time.deltaTime * move);

            if (Input.GetKey(KeyCode.W) && !state.isAerial) {
                player.body.velocity = new Vector2 (player.body.velocity.x, 7);
                if (Input.GetKeyUp(KeyCode.W))
                    player.body.velocity = new Vector2 (player.body.velocity.x, 0);
            //transform.Translate(Time.deltaTime * new Vector2(0,1));
            }
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("ground"))
            player.counter.JumpCount++;
        }
}