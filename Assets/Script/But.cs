using UnityEngine;
using UnityEngine.SceneManagement;

public class But : MonoBehaviour
{
    private const int PLAY_SCENE_INDEX = 9;
    private const int MENU_SCENE_INDEX = 0;
    private const int LEVELS_SCENE_INDEX = 8;

    public void PLAY()
    {
        LoadScene(PLAY_SCENE_INDEX);
    }

    public void MENU()
    {
        LoadScene(MENU_SCENE_INDEX);
    }

    public void FOREVER()
    {
        LoadScene(PLAY_SCENE_INDEX);
    }

    public void LEVELS()
    {
        LoadScene(LEVELS_SCENE_INDEX);
    }

    public void QUIT()
    {
        Application.Quit(); // Uygulamayý kapatýr
    }

    private void LoadScene(int sceneIndex)
    {
        if (sceneIndex >= 0 && sceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogError("Geçersiz sahne numarasý: " + sceneIndex);
        }
    }
}
