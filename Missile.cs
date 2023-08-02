using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float fbSpeed;

    void Update()
    {
        Destroy(gameObject, 3);

        transform.position += transform.forward * fbSpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);

        Destroy(gameObject);
    }
}
