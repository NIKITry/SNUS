using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magaz : MonoBehaviour
{
    public GameObject Magazin;
    public GameObject Assault_Rifle_01_Mag_Empty;
    public AutomaticGunScriptLPFP Automat;
    public GreenTarget Gt;
    bool enter;
    public Text TextAmmo;
    public Text scoresText;
    public Text podskazka;
    GameObject reddot;
    
    public Text Help_Text;
    //bool f = false;
    public bool beal = true;

    public bool control_magaz = false;

    [SerializeField] GameObject palatka_point;


    void Start()
    {
        Magazin.GetComponent<BoxCollider>().enabled = false;
        Assault_Rifle_01_Mag_Empty.SetActive(false);
        scoresText.text = string.Format("");
    }
    // Update is called once per frame
    void Update()
    {
        if (Automat.ammo == 0 && Automat.currentAmmo == 0 && beal == true)
        {
            Assault_Rifle_01_Mag_Empty.SetActive(true);
            Magazin.GetComponent<BoxCollider>().enabled = true;
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            podskazka.text = string.Format("Получите еще 10 патрон для зачетной стрельбы");
        }
        if (enter == true && Input.GetKeyDown(KeyCode.E) && beal == true)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false); // отключение дочернего gameobject
            palatka_point.SetActive(true);
            enter = false;
            Automat.ammo += 10;
           // Automat.currentAmmo += 10;
            Magazin.GetComponent<BoxCollider>().enabled = false;
            Assault_Rifle_01_Mag_Empty.SetActive(false);
            TextAmmo.text = Automat.ammo.ToString();
            GreenTarget.scores = 0;
            Gt.scr = 0;
            scoresText.text = string.Format("Очки: {0}", Gt.scr);

            podskazka.text = string.Format("");
            beal = false;

            control_magaz = true;
        }
        if (enter == true && beal == true){
            if (GameObject.Find("RedDot(Clone)"))
            {
                Destroy(GameObject.Find("RedDot(Clone)"));
            }
        }

      

        if (enter == true)
        {
            Help_Text.text = string.Format("Нажмите Е, чтобы подобрать магазин.");
        }
        if (enter != true)
        {
            Help_Text.text = string.Format("");
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.name == "FPSController")
        {
            enter = true;
            //f = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "FPSController")
        {
            enter = false;
            //f = false;
        }
    }
}
