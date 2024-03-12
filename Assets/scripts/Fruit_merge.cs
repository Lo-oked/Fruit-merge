using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit_merge : MonoBehaviour
{
    [SerializeField] public Vector3 newFruitPos;
    [SerializeField] private Quaternion newFruitRot;
    public int Fruit_value;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            newFruitPos = Vector3.Lerp(collision.gameObject.transform.position, gameObject.transform.position, 0.5f);
            newFruitRot = Quaternion.Lerp(collision.gameObject.transform.rotation, gameObject.transform.rotation, 0.5f);
            Fruit_spawner.fruitmergeposition = newFruitPos;
            Fruit_spawner.fruitspawn = true;
            Fruit_spawner.fruits_value = Fruit_value;
            Fruit_spawner.newFruitRot = newFruitRot;
            Destroy(gameObject);

        }
    }
}
