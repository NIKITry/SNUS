using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Quests : MonoBehaviour
{
    public GameObject Quest_1, Quest_2;
    public GameObject  Fps_2;

    // Start is called before the first frame update
    void Start()
    {
        if (Fps_2.activeSelf)
        {
            Quest_1.SetActive(false);
            Quest_2.SetActive(true);
        }

       //if(Clider_Conrol.koef == 8)
    }

 
}
