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

    public void LEVELS()
    {
        LoadScene(LEVELS_SCENE_INDEX);
    }

    private void LoadScene(int sceneIndex)
    {
        if (SceneManager.sceneCountInBuildSettings > sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogError("Geçiþ yapmak istediðiniz sahne Build Settings'ta bulunmuyor!");
        }
    }
}
