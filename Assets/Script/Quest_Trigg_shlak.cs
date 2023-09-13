using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Trigg_shlak : MonoBehaviour
{
    public bool  enter_shlak;

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enter_shlak = true;
        }

    }
   
}

