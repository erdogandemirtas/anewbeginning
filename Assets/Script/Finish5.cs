using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish5 : MonoBehaviour
{
    public ParticleSystem finishEffect; // Efekt için ParticleSystem
    public Animator animator; // Animator bileþeni

    void OnMouseDown()
    {
        int sceneIndex = 6;

        // Sahne geçiþi için basit bir kontrol
        if (SceneManager.sceneCountInBuildSettings > sceneIndex)
        {
            if (finishEffect != null)
            {
                Instantiate(finishEffect, transform.position, Quaternion.identity); // Efekti oluþtur
            }

            if (animator != null)
            {
                animator.SetTrigger("Finish"); // Animator için bir tetikleyici ayarla
            }

            // Þu anki seviyeyi kaydet
            int currentLevel = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("level", currentLevel);

            // Sahne 6'ya geçiþ yap
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogError("Geçiþ yapmak istediðiniz sahne Build Settings'ta bulunmuyor!");
        }
    }
}
