using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public ParticleSystem clickEffect; // Týklama etkisi için bir ParticleSystem

    void OnMouseDown()
    {
        if (clickEffect != null)
        {
            Instantiate(clickEffect, transform.position, Quaternion.identity); // Týklama etkisini oluþtur
        }
        Destroy(gameObject); // Nesneyi yok et
    }
}