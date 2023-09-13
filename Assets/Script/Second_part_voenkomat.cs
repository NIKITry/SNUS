using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second_part_voenkomat : MonoBehaviour
{
    public GameObject Instr;
    public FirstPersonController FPS;
    public GameObject PolosaQuest, WeaponQUEST;

    bool enter;

    void Update()
    {
        if (enter)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = true;
            FPS.setFreeze(true);
            Instr.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            
        }
    }

    public void Continious()
    {
   
        enter = false;
        Instr.SetActive(false);
        FPS.setFreeze(false);
        Cursor.lockState = CursorLockMode.Locked;
        PolosaQuest.GetComponent<SphereCollider>().enabled = true;
        PolosaQuest.transform.GetChild(0).gameObject.SetActive(true);
        WeaponQUEST.SetActive(true);
    }
}
