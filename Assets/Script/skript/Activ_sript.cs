using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activ_sript : MonoBehaviour
{
    public bool enter;
    public GameObject Timer;
    public GameObject gas
        ;
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = true;
            Timer.GetComponent<Timer>().enabled = true;
            gas.SetActive(true);
        }
       

    }
}
