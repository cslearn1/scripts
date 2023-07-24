using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int Health = 5; //хм
    public GameObject NPCobj; //объект
    public float speed = 1.5f; //скорость
    public int level = 1; // левел
    void Start()
    {
        Health += level; //хп + левел = новое хп
        print("Здоровье игрока:" + Health); // вывод хп в консоль
    }
    void Update()
    {
        Vector3 newPosition = transform.position;// без понятия
        newPosition.x += speed * Time.deltaTime; // передвижение
        transform.position = newPosition;

    }
}
