using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeKVV : MonoBehaviour
{
    [SerializeField] GameObject kvv;
    [SerializeField] GameObject ukv;

    bool enter = false;

    void Update()
    {
        if(enter == true && Input.GetKeyDown(KeyCode.E))
        {
            kvv.SetActive(false);
            ukv.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = true;
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
            enter = false;
    }
}
