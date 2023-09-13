using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public  float time;

    public GameObject Plane;
    public GameObject Bomba;
    public GameObject Raketa;
    public GameObject BOOM;
  
    public GameObject Test;
    public GameObject FinalTest;
    public GameObject Video;
    bool enter;
    int k = 0;
    private void Start()
    {
        k = 0;
        Plane.SetActive(false);
        Bomba.SetActive(false);
        Raketa.SetActive(false);
        BOOM.SetActive(false);
        
        
    }

    private void Update()
    {
        StartCoroutine(Komanda());

        if (enter == true && k == 0)
        {
            Plane.SetActive(true);
            Bomba.SetActive(true);
            Raketa.SetActive(true);
            BOOM.SetActive(true);
  
            k = 1;
        }            
    }



    IEnumerator Komanda()
    {

        yield return new WaitForSeconds(time);
        if (Test.activeSelf ||  FinalTest.activeSelf)
        {
            enter = false;
            
        }
        else
        {
            enter = true;
        }
    }
}
