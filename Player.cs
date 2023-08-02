using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int score = 0;
    public static List<Square> sqs;


    void Awake()
    {
        sqs = new List<Square>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sqs.Count == 0)
        {
            Victory();
        }
    }   

    public static void defeat()
    {
        score = 0;
        UI.ShowDefeatPanel();
    }

    public static void Victory()
    {
        UI.ShowVictoryPanel();
    }
    public static void Restart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
    
}
