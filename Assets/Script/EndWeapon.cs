using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWeapon : MonoBehaviour
{
    public GameObject FPS_1;
    public GameObject FPS_2;
    public GameObject Video;
    public GameObject Minimap_1, Minimap_2;
    int g = 0;
    private void Start()
    {
        if (F.flag_weapon == true)
        {
            FPS_1.SetActive(false);
            FPS_2.SetActive(true);
            Minimap_1.SetActive(false);
            Minimap_2.SetActive(true);
            Video.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void Update()
    {
        if(g != 2)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            g++;
        }
    }
}
