using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_false : MonoBehaviour
{
    public GameObject zadanie;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            zadanie.SetActive(false);
        }
    }
}
