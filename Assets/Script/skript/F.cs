using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F : MonoBehaviour
{
    public GameObject Pers;
    
    public Auttomatic Au;
    public GameObject img;
    public GameObject F_ON;
    public GameObject F_OFF;
    public GameObject M_TRUE;
    public GameObject Itog;
    public GameObject ml_serg;
    public GameObject serg;
    public GameObject st_serg;
    public GameObject prap;
    public GameObject st_prap;
    public static bool flag_weapon;

    int f;
    int k;

    // Start is called before the first frame update
    void Start()
    {
        Pers.GetComponent<Auttomatic>().enabled = false;
        f = 0;
        k = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M) && k % 2 == 0 && k >= 0)
        {
            Pers.GetComponent<Auttomatic>().enabled = true;
            Debug.Log("log");
            img.SetActive(false);
            F_OFF.SetActive(false);
            F_ON.SetActive(true);
            k++;
        }

       else if (Input.GetKeyDown(KeyCode.M) && k % 2 != 0 && k >= 0)
        {
            Pers.GetComponent<Auttomatic>().enabled = false;
            Debug.Log("Unlog");
            img.SetActive(true);
            F_OFF.SetActive(true);
            F_ON.SetActive(false);
            k++;
        }

     if(Au.currentAmmo == 0 && Au.ammo == 0 && f == 0)
        {
            k = -1;
            img.SetActive(false);
            F_OFF.SetActive(false);
            F_ON.SetActive(false);
            M_TRUE.SetActive(true);
        
            f = 1;
           
            }
        if (health.lvl == 2 && GreenTarget.scores >= 480)
            ml_serg.SetActive(true);

        if (health.lvl == 3 && GreenTarget.scores >= 480)
            serg.SetActive(true);

        if (health.lvl == 4 && GreenTarget.scores >= 480)
            st_serg.SetActive(true);

        if (health.lvl == 5 && GreenTarget.scores >= 480)
            prap.SetActive(true);

        if (health.lvl == 6 && GreenTarget.scores >= 480)
            st_prap.SetActive(true);


        if (Input.GetKeyDown(KeyCode.M) && f == 1)
        {
            M_TRUE.SetActive(false);
            Itog.SetActive(true);
            f = 2;
        }
        if (Input.GetKeyDown(KeyCode.Tab) && f == 2)
        {
            flag_weapon = true;
            if(lenguage.len == 0)
            SceneManager.LoadScene("батальон");

            if (lenguage.len == 1)
                SceneManager.LoadScene("batalion");

        }
    }
}
