using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text sText;
        
    void Update()
    {
        sText.text = Player.score.ToString();
    }
}
