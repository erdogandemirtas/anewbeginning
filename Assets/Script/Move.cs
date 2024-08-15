using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f; // Ba�lang�� h�z�
    public float acceleration = 0.002f; // H�z art�� miktar�

    void Start()
    {
        // Ba�lang��ta yap�lacak i�ler varsa buraya ekleyebilirsiniz
    }

    void Update()
    {
        // H�z� zamanla art�r�r
        speed += acceleration * Time.timeScale;

        // Nesneyi hareket ettirir
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
