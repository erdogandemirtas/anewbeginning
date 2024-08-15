using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    // Button dizisini Inspector �zerinden atamak i�in public yap�yoruz
    public Button[] buttons;

    void Start()
    {
        LockSystem();
    }

    // Se�ilen seviyeyi y�kleme fonksiyonu
    public void OpenLevel(string levelName)
    {
        // SceneManager.LoadScene kullanarak sahneyi y�kl�yoruz
        SceneManager.LoadScene(levelName);
    }

    // Kilitleme sistemi
    public void LockSystem()
    {
        // PlayerPrefs'ten kaydedilmi� seviyeyi al�yoruz, yoksa varsay�lan olarak 0 al�yoruz
        int levels = PlayerPrefs.GetInt("level", 0);

        // Butonlar�n etkile�imini kontrol ediyoruz
        for (int i = 0; i < buttons.Length; i++)
        {
            // Buton ismini tamsay�ya �evirerek kar��la�t�rma yap�yoruz
            if (int.TryParse(buttons[i].name, out int buttonLevel))
            {
                // Seviyenin a��labilir olup olmad���n� kontrol ediyoruz
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
