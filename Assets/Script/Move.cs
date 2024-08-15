using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f; // Baþlangýç hýzý
    public float acceleration = 0.002f; // Hýz artýþ miktarý

    void Start()
    {
        // Baþlangýçta yapýlacak iþler varsa buraya ekleyebilirsiniz
    }

    void Update()
    {
        // Hýzý zamanla artýrýr
        speed += acceleration * Time.timeScale;

        // Nesneyi hareket ettirir
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
