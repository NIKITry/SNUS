using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polosa_trenn_trigg : MonoBehaviour
{
    public GameObject Instukciy;
    public GameObject vkl_instr;
    bool enter;
    int k;
    // Start is called before the first frame update
    void Start()
    {
        k = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(k);
        if(enter == true && k == 0)
        {
            Instukciy.SetActive(true);
            k = 1;
        }

       else if((enter == true && Input.GetKeyDown(KeyCode.M) && k == 1))
        {
            Instukciy.SetActive(false);
            vkl_instr.SetActive(true);
            k = 2;
        }

        else if ((enter == true && Input.GetKeyDown(KeyCode.M) && k == 2))
        {
            Instukciy.SetActive(true);
            vkl_instr.SetActive(false);
            k = 1;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            enter = true;

        if( k != 0)
        {
            vkl_instr.SetActive(true);
            k = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
            Instukciy.SetActive(false);
            vkl_instr.SetActive(false);
        }
    }
}
