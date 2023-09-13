using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odejda_dly_geroy : MonoBehaviour
{
    public GameObject Arrows;
    public GameObject Knopka;
    public Camera Golova;
    public GameObject[] odejda;
    public static int k = 0;
    public static int n;
    int i;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Golova.ScreenPointToRay(Input.mousePosition);

        
        for (i = 0; i < odejda.Length; i++)
        {
            if (Physics.Raycast(ray, out hit, 50) && hit.collider.tag == "Odejda" ) 
            {
                Knopka.SetActive(true);

                if (hit.collider.gameObject == odejda[i])
                {
                   

                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        odejda[i].SetActive(false);
                        n++;
                        Knopka.SetActive(false);
                    }
                }
              
               
                Debug.Log("WOOOW");
            }
            else
            {
                Knopka.SetActive(false);
            }

        }

        if (n == 4)
            Arrows.SetActive(true);
    }
}
