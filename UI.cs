using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text sText;
    static UI singleton;
    public GameObject panel;
    public Text panelSText;
    public Text defText;
    public Text vicText;

    private void Awake()
    {
        singleton = this;
    }

    void Update()
    {
        sText.text = Player.score.ToString();
    }

    public static void ShowVictoryPanel()
    {
        singleton.panel.SetActive(true);
        singleton.vicText.gameObject.SetActive(true);
        singleton.panelSText.text = Player.score.ToString();
    }

    public static void ShowDefeatPanel() 
    {
        singleton.panel.SetActive(true);
        singleton.defText.gameObject.SetActive(true);
        singleton.panelSText.text = Player.score.ToString();
    }

    public void OnClickerRestart()
    {
        Player.Restart();
    }
}
