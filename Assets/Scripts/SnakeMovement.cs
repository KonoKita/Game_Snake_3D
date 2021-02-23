using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour
{
    public float Speed = 3.2f;

    public List<GameObject> TailObjects = new List<GameObject>();

    public float z_offset = -1f;

    public float RotationSpeed = 35f;

    public GameObject TailPrefab;

    public Text ScoreText;

    public int score = 0;

    void Start()
    {
        TailObjects.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up*RotationSpeed * 8* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * RotationSpeed * 8 * Time.deltaTime);
        }
    }
   public void AddTail()
    {
        score++;
        Vector3 NewTailPos = TailObjects[TailObjects.Count - 1].transform.position;

        NewTailPos.z -= 0.5f;

        TailObjects.Add(GameObject.Instantiate(TailPrefab, NewTailPos, Quaternion.identity));   
    }
}
