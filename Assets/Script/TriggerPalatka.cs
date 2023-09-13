using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPalatka : MonoBehaviour
{
    public bool enter;
    public static bool StayPalatka;
    public static bool strelba;
    public GameObject TextStart, Instrution, scoreImage;
    public GameObject[] wall;
    public Auttomatic Auttomatic;
    public GameObject Bidvijenie;
    public GameObject Text_zachet;
    public GameObject Rezult, Rezult_text;

    // Start is called before the first frame update
    void Start()
    {
        StayPalatka = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enter && Input.GetKeyDown(KeyCode.E))
        {

            StayPalatka = true;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            enter = false;

            TextStart.SetActive(false);

            Instrution.SetActive(true);

            Bidvijenie.SetActive(false);

            scoreImage.SetActive(true);

            GameObject man, avtomat;
            man = GameObject.FindGameObjectWithTag("Player");

            avtomat = GameObject.FindGameObjectWithTag("weapon");

            man.transform.position = Vector3.MoveTowards(man.transform.position, gameObject.transform.position, 100f);
            man.GetComponent<FirstPersonController>().enabled = false;
            avtomat.GetComponent<Auttomatic>().enabled = false;
           
            for(int i = 0; i < wall.Length; i++)
            {
                wall[i].SetActive(true);
            }
            if (Weapon_trigg.ammo_bool)
                Text_zachet.SetActive(true);
           

        }
        
        if (Auttomatic.currentAmmo == 0 && Auttomatic.ammo == 0)
        {
            TextStart.SetActive(false);
            StayPalatka = false;
            strelba = false;
            Text_zachet.SetActive(false);
            for (int i = 0; i < wall.Length; i++)
            {
                wall[i].SetActive(false);
            }

            if (Weapon_trigg.ammo_bool)
            {
                Rezult.GetComponent<SphereCollider>().enabled = true;
                Rezult_text.SetActive(true);
            }
        }
       
    }
   public void OnCli()
    {
       
        Cursor.lockState = CursorLockMode.Locked;
        GameObject man, avtomat;
        man = GameObject.FindGameObjectWithTag("Player");
        avtomat = GameObject.FindGameObjectWithTag("weapon");
        man.GetComponent<FirstPersonController>().enabled = true;
        avtomat.GetComponent<Auttomatic>().enabled = true;
        Instrution.SetActive(false);
      //  strelba = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){enter = true; TextStart.SetActive(true); }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"){enter = false; TextStart.SetActive(false); }
    }
}
