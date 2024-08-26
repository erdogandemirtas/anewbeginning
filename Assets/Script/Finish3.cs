using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Finish3 : MonoBehaviour, IPointerClickHandler
{
    public ParticleSystem finishEffect; // Efekt için ParticleSystem
    public Animator animator; // Animator bileþeni

    public void OnPointerClick(PointerEventData eventData)
    {
        // Sahne geçiþi için basit bir kontrol
        if (SceneManager.sceneCountInBuildSettings > 4)
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

            // Sahne 4'e geçiþ yap
            SceneManager.LoadScene(4);
        }
        else
        {
            Debug.LogError("Geçiþ yapmak istediðiniz sahne Build Settings'ta bulunmuyor!");
        }
    }
}
