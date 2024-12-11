using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimation : MonoBehaviour
{
    [SerializeField] PlayerStateControl state;
    [SerializeField] Movement movement;
    [SerializeField] Player player;
    void Update()
    {
        /*if (state.isHurt) {
            player.animator.SetBool("isHurt", state.isHurt);
            state.isHurt = false;
        }*/

        if (state.isAerial) {
            player.animator.SetBool("isAerial", true);
            player.animator.SetFloat("yVelocity", player.body.velocity.y);
        } else {
            player.animator.SetBool("isAerial", false);
        }

        if (state.isMoving) {
            player.animator.SetBool("isMoving", true);
            if ((movement.move.x * player.spriteTransform.localScale.x) < 0 ) {
                player.spriteTransform.localScale = new Vector3(player.spriteTransform.localScale.x * (-1), player.spriteTransform.localScale.y, 0);
            }
        } else {
            player.animator.SetBool("isMoving", false);
        } 
    }
}