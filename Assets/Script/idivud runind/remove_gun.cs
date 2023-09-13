using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_gun : MonoBehaviour
{
    public GameObject Camera_without_gun;
    public GameObject gun_cam;

    bool enter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && enter == true)
        {
            Camera_without_gun.SetActive(true);
            gun_cam.SetActive(false);
            this.GetComponent<remove_gun>().enabled = false;
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
