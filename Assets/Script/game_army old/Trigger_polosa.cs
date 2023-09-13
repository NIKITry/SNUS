using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_polosa : MonoBehaviour
{
    public  bool enter;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            enter = true;
    }

   
}
