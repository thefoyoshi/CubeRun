using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button play_button, quit_button;

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
    }
}
