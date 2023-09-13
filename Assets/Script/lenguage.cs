using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lenguage : MonoBehaviour
{
   static public int len = 0;
    public GameObject dropDown;
    public static int f = 0;




    public void Update()
    {
        ValueChanged();
    }
    public void ValueChanged()
    {
        if (dropDown.GetComponent<Dropdown>().value == 0)
        {
            len = 0;
            f = 0;
          // SceneManager.LoadScene("батальон");
        }
         if (dropDown.GetComponent<Dropdown>().value == 1)
        {
            f = 1;
            len = 1;
           // SceneManager.LoadScene("batalion");
        }
    }
}
