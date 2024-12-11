using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject colorCapsule = GameObject.Find("ColorfulCapsule");
        colorCapsule.AddComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 0) {
            GameObject colorCapsule = GameObject.Find("ColorfulCapsule");
            colorCapsule.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (i == 100) {
            GameObject colorCapsule = GameObject.Find("ColorfulCapsule");
            colorCapsule.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        if (i == 200) {
            GameObject colorCapsule = GameObject.Find("ColorfulCapsule");
            colorCapsule.GetComponent<SpriteRenderer>().color = Color.green;
        }
        Debug.Log(i);
        if (i < 201)
        i++;
        else 
        i = 0;
    }
}
