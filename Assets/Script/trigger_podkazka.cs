using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_podkazka : MonoBehaviour
{
   public static GameObject podscazki; // gameobject с множеством наборов текстов(canvas -> help)
    public bool enter;
    public static int number_child;
    // Start is called before the first frame update
    public void Start()
    {
        enter = false;
        podscazki = GameObject.Find("help");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(number_child);
        if (enter == true)
        {
            podscazki.transform.GetChild(number_child).gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                podscazki.transform.GetChild(number_child).gameObject.SetActive(false);
               // number_child++;
                enter = false;
            }
        }

        if (enter == false)
        {
            podscazki.transform.GetChild(number_child).gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = false;
        }
    }
}
