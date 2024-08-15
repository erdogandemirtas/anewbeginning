using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public ParticleSystem clickEffect; // T�klama etkisi i�in bir ParticleSystem

    void OnMouseDown()
    {
        if (clickEffect != null)
        {
            Instantiate(clickEffect, transform.position, Quaternion.identity); // T�klama etkisini olu�tur
        }
        Destroy(gameObject); // Nesneyi yok et
    }
}