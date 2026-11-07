using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button play_button, settings_button, settings_close_button, quit_button;
    public GameObject settings_window;

    void Start()
    {
        settings_window.SetActive(false);
    }
    void Update()
    {
        if(play_button.IsPressed())
        {
            SceneManager.LoadScene(1);
        }
        if(quit_button.IsPressed())
        {
            Application.Quit();
        }
        if(settings_button.IsPressed())
        {
            settings_window.SetActive(true);
        }
        if(settings_close_button.IsPressed())
        {
            settings_window.SetActive(false);
        }
    }
}
