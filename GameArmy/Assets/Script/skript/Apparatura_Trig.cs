using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apparatura_Trig : MonoBehaviour
{
    public GameObject image, podskazka_open, podskazka_close, apparat;
    bool enter, _button = false;

    private void Start()
    {
        
    }
    private void Update()
    {
        if(enter == true && Input.GetKeyDown(KeyCode.E) && _button == false)
        {
            image.SetActive(true);
            podskazka_open.SetActive(false);
            podskazka_close.SetActive(true);
            _button = !_button;
        }

        else if(enter == true && Input.GetKeyDown(KeyCode.E) && _button == true)
        {
            image.SetActive(false);
            podskazka_open.SetActive(true);
            podskazka_close.SetActive(false);
            _button = !_button;
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            podskazka_open.SetActive(true);
            apparat.GetComponent<Outline>().enabled = true;
            enter = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = false;
            image.SetActive(false);
            podskazka_open.SetActive(false);
            podskazka_close.SetActive(false);
            apparat.GetComponent<Outline>().enabled = false;
            _button = false;
        }
    }
}
