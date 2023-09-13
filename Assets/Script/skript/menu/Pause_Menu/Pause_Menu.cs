using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    [SerializeField] static bool pause_Game = false;
    [SerializeField] GameObject pause_Menu_Panel;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pause_Game == false)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                pause_Menu_Panel.SetActive(true);
                Time.timeScale = 0f;
                pause_Game = true;
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                pause_Menu_Panel.SetActive(false);
                Time.timeScale = 1.0f;
                pause_Game = false;
            }
        }
    }


    public void ContinueBt()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pause_Menu_Panel.SetActive(false);
        Time.timeScale = 1.0f;
        pause_Game = false;
    }

    public void SettingsBt()
    {

    }

    public void BackBt()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }
}
