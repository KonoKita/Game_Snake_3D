using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public bool DisappearActivation = false;
    private Vector3 MiniShard = new Vector3(0.01f, 0.01f, 0.01f);
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            other.GetComponent<SnakeMovement>().AddTail();
            Destroy(gameObject);
        }

    }
}