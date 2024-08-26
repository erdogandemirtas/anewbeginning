using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Stone : MonoBehaviour, IPointerClickHandler
{
    public int sceneToLoad = 7; // Yüklemek istediðiniz sahne numarasýný buraya girin

    public void OnPointerClick(PointerEventData eventData)
    {
        // Sahneyi yükler
        LoadScene();
    }

    void LoadScene()
    {
        // Sahne numarasýný kontrol eder
        if (sceneToLoad >= 0 && sceneToLoad < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Geçersiz sahne numarasý: " + sceneToLoad);
        }
    }
}
