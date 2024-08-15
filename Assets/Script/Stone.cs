using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stone : MonoBehaviour
{
    public int sceneToLoad = 7; // Y�klemek istedi�iniz sahne numaras�n� buraya girin

    void OnMouseDown()
    {
        // Sahneyi y�kler
        LoadScene();
    }

    void LoadScene()
    {
        // Sahne numaras�n� kontrol eder
        if (sceneToLoad >= 0 && sceneToLoad < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Ge�ersiz sahne numaras�: " + sceneToLoad);
        }
    }
}