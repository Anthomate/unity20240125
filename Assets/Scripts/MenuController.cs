using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button playButton;
    public Button creditsButton;
    public Button backButton;
    public Button quitButton;

    void Start()
    {
        InitializeButtons();
    }

    void InitializeButtons()
    {
        if (playButton != null)
        {
            playButton.onClick.AddListener(() => ChangeScene("Game"));
            Debug.Log("Play button initialized");
        }
        if (creditsButton != null)
        {
            creditsButton.onClick.AddListener(() => ChangeScene("Credit"));
            Debug.Log("Credits button initialized");
        }
        if (backButton != null)
        {
            backButton.onClick.AddListener(() => ChangeScene("Menu"));
            Debug.Log("Back button initialized");
        }
        if (quitButton != null)
        {
            quitButton.onClick.AddListener(Quit);
            Debug.Log("Quit button initialized");
        }
    }


    public void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
