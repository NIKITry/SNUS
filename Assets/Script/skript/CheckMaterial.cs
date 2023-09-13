using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMaterial : MonoBehaviour
{
    public GameObject idle1, idle2;
    public Odejda_dly_geroy odejda;
    
   

    public void Update()
    {
        if (Odejda_dly_geroy.n == odejda.odejda.Length && idle1.activeSelf )
        {
            idle1.SetActive(false);
            idle2.SetActive(true);
            
        }
    }
}
  
