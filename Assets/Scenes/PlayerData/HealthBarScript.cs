using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    //UnityEvent HealthBarListener = new UnityEvent();
    [SerializeField] PlayerStateControl PlayerHealth;
    [SerializeField] Slider slider;

    // Update is called once per frame
    void Update()
    {
        slider.value = PlayerHealth.Health;
    }
}
