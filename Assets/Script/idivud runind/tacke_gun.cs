using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tacke_gun : MonoBehaviour
{
    public GameObject Camera_without_gun;
    public GameObject gun_cam;

    bool enter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && enter == true)
        {
            Camera_without_gun.SetActive(false);
            gun_cam.SetActive(true);
            this.GetComponent<tacke_gun>().enabled = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = false;
        }
    }
}
