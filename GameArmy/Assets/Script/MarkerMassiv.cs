using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerMassiv : MonoBehaviour
{
    public GameObject[] Markers;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i  = 1; i < Markers.Length; i++)
        {
             Markers[i].SetActive(false);

            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
