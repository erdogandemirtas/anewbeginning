using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Stone : MonoBehaviour, IPointerClickHandler
{
    public int sceneToLoad = 7; // Y�klemek istedi�iniz sahne numaras�n� buraya girin

    public void OnPointerClick(PointerEventData eventData)
    {
        // Sahneyi y�kler
        LoadScene();
    }

    void LoadScene()
    {
        // Sahne numaras�n� kontrol eder
        if (sceneToLoad >= 0 && sceneToLoad < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Ge�ersiz sahne numaras�: " + sceneToLoad);
        }
    }
}
