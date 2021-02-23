using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{
    public float RotationSpeed = 35f;

    public float Speed;

    public Vector3 TailTarget;

    public GameObject TailTargetObject;

    public SnakeMovement MainSnake;

    public int Index;
    void Start() 
    {
        MainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        TailTargetObject = MainSnake.TailObjects[MainSnake.TailObjects.Count - 2];
        Speed = MainSnake.Speed;
        Index = MainSnake.TailObjects.IndexOf(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        TailTarget = TailTargetObject.transform.position;
        transform.LookAt(TailTarget);
        
        transform.position = Vector3.Lerp(transform.position, TailTarget, Time.deltaTime * Speed * 2f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if (Index > 2)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
