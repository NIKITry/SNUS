using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UKV : MonoBehaviour
{
    [SerializeField]
    GameObject kvv;
    [SerializeField]
    GameObject nikitich;
    

    bool enter;

    public GameObject Audio_Bkl;
    public GameObject Audio_Nastr;
    public GameObject Audio_Peredacha;

    public GameObject AH_1_5;
    public GameObject ushi;
    public GameObject arm;


    void Start()
    {
        kvv.SetActive(false);
        Audio_Bkl.SetActive(false);
        Audio_Nastr.SetActive(false);
        Audio_Peredacha.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if(enter == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                kvv.SetActive(true);
                nikitich.SetActive(false);
                ushi.SetActive(true);
                AH_1_5.SetActive(true);
                StartCoroutine(armCoroutine());
                StartCoroutine(stopBroadcastCoroutine());
            }
        }
    }

    IEnumerator armCoroutine()
    {
        yield return new WaitForSeconds(1.0f);
        arm.GetComponent<Animator>().enabled = true;
        Audio_Nastr.SetActive(true);
        StartCoroutine(broadcastCoroutine());        
    }

    IEnumerator broadcastCoroutine()
    {
        yield return new WaitForSeconds(3.0f);
        Audio_Nastr.SetActive(false);
        Audio_Peredacha.SetActive(true);
    }
    
    IEnumerator stopBroadcastCoroutine()
    {
        yield return new WaitForSeconds(20.0f);
        kvv.SetActive(false);
        nikitich.SetActive(true);
    }
    
    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = true;
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
            enter = false;
    }
}
