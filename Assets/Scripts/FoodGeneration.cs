using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    public float XSize = 8.8f;

    public float ZSize = 8.8f;

    public GameObject CurFood;

    public GameObject foodPrefab;

    public Vector3 CurFoodPos;

    void AddNewFood()
    {
        RandomPos();
        CurFood = GameObject.Instantiate(foodPrefab, CurFoodPos, Quaternion.identity);
    }

    void RandomPos()
    {
        CurFoodPos = new Vector3(Random.Range(XSize * -1, XSize), 0.25f, Random.Range(ZSize * -1, ZSize));
    }

    void Update() 
    {
        if (!CurFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}
