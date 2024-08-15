using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    public int sceneToLoad = 7; // Yüklemek istediðiniz sahne numarasýný buraya girin

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            LoadScene();
        }
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
