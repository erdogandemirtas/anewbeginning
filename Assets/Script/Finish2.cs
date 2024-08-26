using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Finish2 : MonoBehaviour, IPointerClickHandler
{
    public ParticleSystem finishEffect; // Týklama sonrasý efekt için ParticleSystem
    public Animator animator; // Animator bileþeni

    public void OnPointerClick(PointerEventData eventData)
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

        // Sahne 3'e geçiþ yap
        SceneManager.LoadScene(3);
    }
}
