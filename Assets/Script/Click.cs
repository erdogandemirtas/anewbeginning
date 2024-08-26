using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IPointerClickHandler
{
    public ParticleSystem clickEffect; // Týklama etkisi için bir ParticleSystem

    public void OnPointerClick(PointerEventData eventData)
    {
        if (clickEffect != null)
        {
            Instantiate(clickEffect, transform.position, Quaternion.identity); // Týklama etkisini oluþtur
        }
        Destroy(gameObject); // Nesneyi yok et
    }
}
