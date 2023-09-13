using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESC_Bat : MonoBehaviour
{
    private bool klavisha;
    public GameObject menuCanv;
    public GameObject herous_1, herous_2;
    public GameObject _continue;
    //public GameObject settings;
    public GameObject exitOnMenu;
    public GameObject[] Test;
    public GameObject[] lvl_zvanie;
    public int timer = 1;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            klavisha = !klavisha;

           // Debug.Log(klavisha);
            if (klavisha)
            {
             if(lenguage.len == 0)
                menuCanv.transform.GetChild(0).gameObject.SetActive(true);

             if (lenguage.len == 1)
                    menuCanv.transform.GetChild(1).gameObject.SetActive(true);

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                if (lenguage.len == 0)
                    menuCanv.transform.GetChild(0).gameObject.SetActive(false);

                if (lenguage.len == 1)
                    menuCanv.transform.GetChild(1).gameObject.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            //SceneManager.LoadScene("snus");
        }
    }

    public void OnClickExit()
    {
       
        for (int i = 0; i < Test.Length; i++){
            Test[i].SetActive(true);

        }

        for(int i = 0; i < lvl_zvanie.Length; i++)
        {
           
            if(i > 0)
            {
                lvl_zvanie[i].SetActive(false);
            }

        }
        health.xp = 0;
        health.min_xp = 0;
        Debug.Log("!!!!");
        herous_1.SetActive(true);
        herous_2.SetActive(false);

        SceneManager.LoadScene("авторизация");
    }

    public void OnClickContinue()
    {
        klavisha = !klavisha;
        if (lenguage.len == 0)
            menuCanv.transform.GetChild(0).gameObject.SetActive(false);

        if (lenguage.len == 1)
            menuCanv.transform.GetChild(1).gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    /*public void OnClickSettings()
    {

    }*/
}
