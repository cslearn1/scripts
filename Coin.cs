using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject ccoin;
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.CollectCoins();
        Destroy(gameObject);
    }
}
