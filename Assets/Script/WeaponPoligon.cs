using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPoligon : MonoBehaviour
{

    public GameObject Welcome;
    bool enter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Contine()
    {
        Welcome.SetActive(false);
      
        Cursor.lockState = CursorLockMode.Locked;
       
        GameObject man;
        man = GameObject.FindGameObjectWithTag("Player");
        man.GetComponent<FirstPersonController>().enabled = true;
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            enter = true;

            Welcome.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            GameObject man;
            man = GameObject.FindGameObjectWithTag("Player");
            man.GetComponent<FirstPersonController>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            enter = false;
    }
}
