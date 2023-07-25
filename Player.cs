using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class Player : MonoBehaviour
{
    private int health = 10;
    public string sceneName;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("υο =" + health);
    }
    public void Dead()
    {
        if(health >= 0)
        {
            EditorSceneManager.LoadScene(sceneName);
        }
    }
}
