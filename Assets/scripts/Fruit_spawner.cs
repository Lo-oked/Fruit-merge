using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit_spawner : MonoBehaviour
{
    public List<GameObject> Fruits;


    public static bool fruitspawn;
    public bool can_spawn;
    public static Vector3 fruitmergeposition;
    public static Quaternion newFruitRot;
    Vector3 Fakefruitpos;
    

    public float timeRemaining = 1;

    public static int fruits_value;
    public static int score;

    public List<GameObject> fakefruit;

    public List<int> NextFruitinLine;

    public AudioClip Pop1;
    public AudioClip Pop2;




    void Start()
    {
        Fakefruitpos = transform.position;
        
    }
    void Update()
    {
        


        if (NextFruitinLine.Count < 2)
        {
            NextFruit();
            
        }

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            can_spawn = false;
        }
        else { can_spawn = true; }
        fruit_merge();

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonUp(0) && can_spawn == true)
        {      
            Instantiate(Fruits[NextFruitinLine[0]], new Vector3(mousePosition.x, gameObject.transform.position.y, 0), Quaternion.identity);
            AudioSystem.Play(Pop1);
            fakefruit[NextFruitinLine[0]].SetActive(false);
            timeRemaining = 1;
            can_spawn = false;
            NextFruitinLine.RemoveAt(0);
        }

        print(score);

    }

    void fruit_merge()
    {
        if (fruitspawn == true)
        {
            fruitspawn = false;
            Instantiate(Fruits[fruits_value], fruitmergeposition, newFruitRot);
            AudioSystem.Play(Pop2);
            score = score + fruits_value * 5;
        }
    }

    void fakeFruitSpawn()
    {
        fakefruit[NextFruitinLine[0]].SetActive(true);
    }

    void NextFruit()
    {
        NextFruitinLine.Add(Random.Range(0, 2));
        fakeFruitSpawn();
    }
}
