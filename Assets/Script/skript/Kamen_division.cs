using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kamen_division : MonoBehaviour
{
    bool enter;
    public GameObject Kamen;
    public GameObject FPSNIK;
    public GameObject FPSNIK_camera;
    public GameObject Panel;
    public GameObject Video_ob_uzlah_svyzi;
    public GameObject Video_ob_divisione;
    public GameObject LordCanvas;
  static public  bool video_enter = false;
     bool yes;
     bool no;

    void Start()
    {
        yes = false;
        no = false;
        k = 0;
        enter = false;
        Video_ob_uzlah_svyzi.SetActive(false);
        Video_ob_divisione.SetActive(false);
        
    }
    int k = 0;
    // Update is called once per frame
    void Update()
    {

        if (enter == true )
        {
            
            
            Debug.Log(yes);
            if (no == true)
            {
                Panel.SetActive(false);
                if (!Video_ob_uzlah_svyzi.activeSelf && k == 0)
                {
                    Video_ob_uzlah_svyzi.SetActive(true);
                    k = 1;

                }
                if (!Video_ob_uzlah_svyzi.activeSelf && video_enter == false)
                {
                    Video_ob_divisione.SetActive(true);
                    video_enter = true;
                }
            }
        }

         if(yes == true)
        {
           // Kamen.SetActive(false);
        //   Panel.SetActive(false);
           
          
           
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            enter = true;
        Cursor.visible = true;
        LordCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        FPSNIK.GetComponent<FPSCONROL>().enabled = false;
        FPSNIK.GetComponent<тело>().enabled = false;
        FPSNIK_camera.GetComponent<тело>().enabled = false;
        Panel.SetActive(true);

    }
  
    public void DA_znay()
    {
         LordCanvas.SetActive(true);
        Debug.Log("!!!");
        yes = true;
        Panel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        FPSNIK.GetComponent<FPSCONROL>().enabled = true;
        FPSNIK.GetComponent<тело>().enabled = true;
        FPSNIK_camera.GetComponent<тело>().enabled = true;

    }
    public void NET_neznay()
    {
        Debug.Log("!!!");
        no = true;
        Panel.SetActive(false);

    }
}
