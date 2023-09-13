using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_trigg : MonoBehaviour
{
    public GameObject Weapon_man;
    public Auttomatic Auttomatic;
    public GameObject weapon , Welcome_trigger;
    public GameObject podskazka, Ammo, Text_navigashon;
    public GameObject Bidvijenie;
    public GreenTarget GreenTarget;
    bool enter;
    public static bool ammo_bool;
    // Start is called before the first frame update
    void Start()
    {
        weapon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enter && Input.GetKeyDown(KeyCode.E) && !Weapon_man.activeSelf)
        {
            weapon.SetActive(true);
            podskazka.SetActive(false);
            Ammo.SetActive(true);
            Welcome_trigger.SetActive(true);
            Bidvijenie.SetActive(true);

        }

        if (Auttomatic.currentAmmo == 0 && Auttomatic.ammo == 0 )
        {
            Text_navigashon.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E) && enter) 
            {
               
                Auttomatic.ammo = 10;

                Text_navigashon.SetActive(false);

                podskazka.SetActive(false);

                Bidvijenie.SetActive(true);

                ammo_bool = true;    

                GreenTarget.scores = 0; 
                GreenTarget.six = 0;
                GreenTarget.sev = 0;
                GreenTarget.vos = 0;
                GreenTarget.nine = 0;
                GreenTarget.ten = 0;
                GreenTarget.oldscore = 0;
                gameObject.SetActive(false);

            }
               
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = true;
            podskazka.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            podskazka.SetActive(false);
            enter = false;
        }
    }
}
