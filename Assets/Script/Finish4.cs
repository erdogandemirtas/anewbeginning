using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish4 : MonoBehaviour
{
    public ParticleSystem finishEffect; // Efekt için ParticleSystem
    public Animator animator; // Animator bileþeni

    void OnMouseDown()
    {
        // Sahne geçiþi için basit bir kontrol
        if (SceneManager.sceneCountInBuildSettings > 5)
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

            // Sahne 5'e geçiþ yap
            SceneManager.LoadScene(5);
        }
        else
        {
            Debug.LogError("Geçiþ yapmak istediðiniz sahne Build Settings'ta bulunmuyor!");
        }
    }
}
