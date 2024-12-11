using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int JumpCount;
    [SerializeField] private TextMeshProUGUI CounterText;

    // Update is called once per frame
    void Update()
    {
        if (JumpCount > 0)
            CounterText.text = JumpCount.ToString();
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("ground"))
            JumpCount++;
    }
}
