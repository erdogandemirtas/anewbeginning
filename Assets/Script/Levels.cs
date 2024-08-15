using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    // Button dizisini Inspector üzerinden atamak için public yapýyoruz
    public Button[] buttons;

    void Start()
    {
        LockSystem();
    }

    // Seçilen seviyeyi yükleme fonksiyonu
    public void OpenLevel(string levelName)
    {
        // SceneManager.LoadScene kullanarak sahneyi yüklüyoruz
        SceneManager.LoadScene(levelName);
    }

    // Kilitleme sistemi
    public void LockSystem()
    {
        // PlayerPrefs'ten kaydedilmiþ seviyeyi alýyoruz, yoksa varsayýlan olarak 0 alýyoruz
        int levels = PlayerPrefs.GetInt("level", 0);

        // Butonlarýn etkileþimini kontrol ediyoruz
        for (int i = 0; i < buttons.Length; i++)
        {
            // Buton ismini tamsayýya çevirerek karþýlaþtýrma yapýyoruz
            if (int.TryParse(buttons[i].name, out int buttonLevel))
            {
                // Seviyenin açýlabilir olup olmadýðýný kontrol ediyoruz
                buttons[i].interactable = (levels + 1 >= buttonLevel);
            }
            else
            {
                Debug.LogWarning($"Button name '{buttons[i].name}' is not a valid level number.");
                buttons[i].interactable = false;
            }
        }
    }
}
