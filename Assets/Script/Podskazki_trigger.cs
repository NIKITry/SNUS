using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podskazki_trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject podskazka;
    bool enter;

    public void Update()
    {
        if(enter == true && Input.GetKeyDown(KeyCode.E))
        {
            podskazka.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
       if(col.tag == "Player")
        {
            podskazka.SetActive(true);
            enter = true;
        } 
    }
}
