using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_polosa_trenn : MonoBehaviour
{
    bool enter;
    public GameObject Canvas_finish;
    public Transform spawn;

   public void Update()
    {
        if(enter == true)
        {
            GameObject man;
            man = GameObject.FindGameObjectWithTag("Player");
            man.GetComponent<FirstPersonController>().enabled = false;
            Canvas_finish.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Polosa_start.trennirovka = false;
            
            
        }
        
    }
    public void Zanova() 

    {
        GameObject man;
        man = GameObject.FindGameObjectWithTag("Player");
        man.transform.position = Vector3.MoveTowards(man.transform.position, spawn.position, 100f);
        Cursor.lockState = CursorLockMode.Locked;
        Canvas_finish.SetActive(false);
    }

    public void Zachet()
    {
        GameObject man;
        man = GameObject.FindGameObjectWithTag("Player");
        man.transform.position = Vector3.MoveTowards(man.transform.position, spawn.position, 100f);
      //  Cursor.lockState = CursorLockMode.Locked;
        Canvas_finish.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = true;
          
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
            gameObject.SetActive(false);
            Canvas_finish.SetActive(false);
        }
    }
}
