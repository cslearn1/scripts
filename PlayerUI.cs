using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinCount;
    public Slider bar;

    void Update()
    {
        coinCount.text = player.coins.ToString();

        bar.maxValue = player.maxHealth;
        bar.value = player.health;
    }
}
