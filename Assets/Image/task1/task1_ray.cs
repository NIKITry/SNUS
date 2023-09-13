using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1_ray : MonoBehaviour
{
    //public task1 task_1_start;
    public static bool enter;
    public Camera FPS_camera;
    float ray_distance = 20f;

    public GameObject binocl;
    public GameObject topor;
    public GameObject lopata;

    public GameObject Podskazka;
    int k = 0;
    public GameObject markerImage_1;
    public GameObject markerImage_2;
    public GameObject markerImage_3;
    /*public GameObject markerImage_4;
    public GameObject markerImage_5;
    public GameObject markerImage_6;
    public GameObject markerImage_7;
    public GameObject markerImage_8;
    public GameObject markerImage_9;
    public GameObject markerImage_10;
    public GameObject markerImage_11;
    public GameObject markerImage_12;*/

    void Update()
    {
        RaycastHit hit;
        Ray ray = FPS_camera.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(transform.position, ray.direction * ray_distance);
        if (Physics.Raycast(ray, out hit, ray_distance) )
        {
            if (hit.transform.tag == "binoc")
            {
                Podskazka.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E)) {
                    binocl.SetActive(false);
                    markerImage_3.SetActive(true);
                    k++;
                }
            }
            else
                Podskazka.SetActive(false);

            if (hit.collider.name == "topor_col")
            {
                Podskazka.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    k++;
                    topor.SetActive(false);
                    markerImage_1.SetActive(true);
                }
            }

            if (hit.collider.name == "lopata_col")
            {
                Podskazka.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    k++;
                    lopata.SetActive(false);
                    markerImage_2.SetActive(true);
                }
            }

        }
        if(k == 3)
        {
          //// BiG_Quest.tmp++;
            k = 4;
        }

    }
}
