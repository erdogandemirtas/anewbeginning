using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Finish2 : MonoBehaviour, IPointerClickHandler
{
    public ParticleSystem finishEffect; // T�klama sonras� efekt i�in ParticleSystem
    public Animator animator; // Animator bile�eni

    public void OnPointerClick(PointerEventData eventData)
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

        // Sahne 3'e ge�i� yap
        SceneManager.LoadScene(3);
    }
}
