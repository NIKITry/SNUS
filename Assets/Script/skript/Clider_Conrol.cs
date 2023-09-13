using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clider_Conrol : MonoBehaviour
{
    public GameObject[] Clider;
  
    bool[] flag = null;
    public static int koef;
    // Start is called before the first frame update

    private void Start()
    {
        //koef = 0;
      //  Debug.Log(koef);
        this.flag = new bool[8];
        for (int i = 0; i < 8; i++)
        {
            flag[i] = false;
           
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(koef != 8)
            for(int i = 0; i < Clider.Length; i++)
                if(Clider[i].activeSelf && flag[i] == false)
                {
                    flag[i] = true;
                    koef++;
                }
    }
}
