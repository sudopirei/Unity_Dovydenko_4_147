using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject[] circlesFalling = GameObject.FindGameObjectsWithTag("circleFalling");
        
        for(int i = 0; i < 28; i++)
        {
            circlesFalling[i].AddComponent<Rigidbody2D>();
            circlesFalling[i].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            Debug.Log("It should have fallen now.");
        }
    }
}