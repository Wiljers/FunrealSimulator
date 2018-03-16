using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {

    [SerializeField]
    Canvas AndroidController;

    public void LoadByIndex(int sceneIndex)
    {
        if (Application.platform == RuntimePlatform.WindowsPlayer)
        { AndroidController.gameObject.SetActive(false); }

        if (Application.platform == RuntimePlatform.Android)
        { AndroidController.gameObject.SetActive(true); }

        if (Time.timeScale == 0)
        { Time.timeScale = 1; }
        SceneManager.LoadScene(sceneIndex);
    }
}
