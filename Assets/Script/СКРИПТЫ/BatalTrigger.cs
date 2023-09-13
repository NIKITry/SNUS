using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatalTrigger : MonoBehaviour
{ 
bool enter;
    public GameObject Nagat_F_rus;
    public GameObject Otgat_F_rus;

    public GameObject Nagat_F_eng;
    public GameObject Otgat_F_eng;

    public GameObject Plakat;
    public  int k = 0;

    public void Start()
    {
        Nagat_F_rus.SetActive(false);
        Otgat_F_rus.SetActive(false);
        Nagat_F_eng.SetActive(false);
        Otgat_F_eng.SetActive(false);
    }
    public void Update()
    {

        if(enter == true)
        { 
            
                

            if (Input.GetKeyDown(KeyCode.F) && k % 2 == 0)
            {
                if (lenguage.len == 0)
                {
                    Nagat_F_rus.SetActive(false);
                    Otgat_F_rus.SetActive(true);
                }

                if (lenguage.len == 1)
                {
                    Nagat_F_eng.SetActive(false);
                    Otgat_F_eng.SetActive(true);
                }


                Plakat.SetActive(true); 
	             k++;
            }
	        else if(Input.GetKeyDown(KeyCode.F) && k % 2 != 0)
            {
                if (lenguage.len == 0)
                {
                    Nagat_F_rus.SetActive(true);
                    Otgat_F_rus.SetActive(false);
                }

                if (lenguage.len == 1)
                {
                    Nagat_F_eng.SetActive(true);
                    Otgat_F_eng.SetActive(false);
                }

                Plakat.SetActive(false);  
	             k++;
            }
	    }
        else if(enter == false){
 
            Plakat.SetActive(false);
           // Nagat_F.SetActive(false);
           // Otgat_F.SetActive(false);
            k = 0;
         
	    }
    }
private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (lenguage.len == 0)
            {
                Nagat_F_rus.SetActive(true);   
            }

            if (lenguage.len == 1)
            {
                Nagat_F_eng.SetActive(true);
            }
            enter = true;
        }
    }
private void OnTriggerExit(Collider col)
{
        if (col.tag == "Player")
        {
            Nagat_F_rus.SetActive(false);
            Otgat_F_rus.SetActive(false);
            Nagat_F_eng.SetActive(false);
            Otgat_F_eng.SetActive(false);
        }

        enter = false;

    }
}