using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class tp : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}
