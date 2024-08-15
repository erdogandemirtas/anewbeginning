using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish3 : MonoBehaviour
{
    public ParticleSystem finishEffect; // Efekt i�in ParticleSystem
    public Animator animator; // Animator bile�eni

    void OnMouseDown()
    {
        // Sahne ge�i�i i�in basit bir kontrol
        if (SceneManager.sceneCountInBuildSettings > 4)
        {
            if (finishEffect != null)
            {
                Instantiate(finishEffect, transform.position, Quaternion.identity); // Efekti olu�tur
            }

            if (animator != null)
            {
                animator.SetTrigger("Finish"); // Animator i�in bir tetikleyici ayarla
            }

            // �u anki seviyeyi kaydet
            int currentLevel = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("level", currentLevel);

            // Sahne 4'e ge�i� yap
            SceneManager.LoadScene(4);
        }
        else
        {
            Debug.LogError("Ge�i� yapmak istedi�iniz sahne Build Settings'ta bulunmuyor!");
        }
    }
}
