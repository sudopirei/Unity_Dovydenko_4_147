using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D body;
    public PlayerStats playerStats;
    public Animator animator;
    public Transform spriteTransform;
    public Counter counter;
    /*public PlayerStateControl state;
    public Movement movement;*/
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectWithTag("counter").GetComponent<Counter>();
        body = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        spriteTransform = GameObject.Find("Sprite").GetComponent<Transform>();
    }
}
