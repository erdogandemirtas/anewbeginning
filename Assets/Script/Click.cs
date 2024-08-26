using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IPointerClickHandler
{
    public ParticleSystem clickEffect; // T�klama etkisi i�in bir ParticleSystem

    public void OnPointerClick(PointerEventData eventData)
    {
        if (clickEffect != null)
        {
            Instantiate(clickEffect, transform.position, Quaternion.identity); // T�klama etkisini olu�tur
        }
        Destroy(gameObject); // Nesneyi yok et
    }
}
