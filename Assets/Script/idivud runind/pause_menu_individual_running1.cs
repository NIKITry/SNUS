using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_menu_individual_running : MonoBehaviour
{
    [SerializeField] static bool pause_Game = false;
    [SerializeField] GameObject pause_Menu_Panel;
    [SerializeField] GameObject kamaz;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause_Game == false)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                pause_Menu_Panel.SetActive(true);
                this.GetComponent<AudioSource>().enabled = false;
                if(kamaz.GetComponent<CarControler>().enabled == true)
                {
                    kamaz.GetComponent<AudioSource>().enabled = false;
                }
                Time.timeScale = 0f;
                pause_Game = true;
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                pause_Menu_Panel.SetActive(false);
                this.GetComponent<AudioSource>().enabled = true;
                if (kamaz.GetComponent<CarControler>().enabled == true)
                {
                    kamaz.GetComponent<AudioSource>().enabled = true;
                }
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
        this.GetComponent<AudioSource>().enabled = true;
        if (kamaz.GetComponent<CarControler>().enabled == true)
        {
            kamaz.GetComponent<AudioSource>().enabled = true;
        }
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
