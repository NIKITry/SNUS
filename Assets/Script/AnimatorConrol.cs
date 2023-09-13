using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorConrol : MonoBehaviour
{
   
    public static int  number_child;
    public GameObject[] object_animator;
  
    public bool enter;
    // Start is called before the first frame update
    public void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enter == true)
        {
           
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                number_child++;

                for (int i = 0; i < object_animator.Length; i++)

                    object_animator[i].GetComponent<Animator>().enabled = true;
            }
        }

        if (enter == false)
        {
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
