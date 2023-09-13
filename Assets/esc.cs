using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esc : MonoBehaviour
{
    private bool klavisha;
    public GameObject menuCanv;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            klavisha = !klavisha;

            
            if (klavisha)
            {
                menuCanv.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
            }

            else if (!klavisha)
            {
                menuCanv.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1f;
            }
        }

    }

    public void Cont()
    {
        menuCanv.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        klavisha = !klavisha;
    }

public void ExitBt()
    {
        Application.Quit();
    }
}
