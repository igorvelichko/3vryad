using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject LeaveMenu;
    public GameObject Pause;

    public void ButtonsMenu(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }

    public void OpenCloseLeaveMenu(bool open_close)
    {
        LeaveMenu.SetActive(open_close);
    }

    public void LeaveGame()
    {
        Application.Quit();
    }

    public void VKURL()
    {
        Application.OpenURL("https://vk.com/prostto_dodik");
    }

    public void PauseButton(bool pause_play)
    {
        Pause.SetActive(pause_play);
    }
}
