using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stone : MonoBehaviour
{
    public int sceneToLoad = 7; // Yüklemek istediðiniz sahne numarasýný buraya girin

    void OnMouseDown()
    {
        // Sahneyi yükler
        LoadScene();
    }

    void LoadScene()
    {
        // Sahne numarasýný kontrol eder
        if (sceneToLoad >= 0 && sceneToLoad < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Geçersiz sahne numarasý: " + sceneToLoad);
        }
    }
}