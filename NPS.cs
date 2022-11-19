using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    //здоровье инписи
    public int health = 10;

    // Уровень инписи
    public int level = 1;

    // скорость инписи
    public float speed = 1.9f;
    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("Жизней;" + health);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
 


    }
}
