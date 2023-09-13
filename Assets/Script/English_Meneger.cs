using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class English_Meneger : MonoBehaviour
{
   
    public GameObject[] Russian, English;
    void Start()
    {
        for(int i  = 0; i < Russian.Length; i++)
        {
            Russian[i].SetActive(false);
        }
        for(int i = 0; i < English.Length; i++)
        {
            English[i].SetActive(false);
        }
       
        if (lenguage.len == 1)
        {
            for (int i = 0; i < English.Length; i++)
            {
                English[i].SetActive(true);
            }
        }
        if (lenguage.len == 0)
        {
            for (int i = 0; i < Russian.Length; i++)
            {
                Russian[i].SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
