using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitInKAMAZ : MonoBehaviour
{
    [SerializeField] GameObject kamaz_cam;
    [SerializeField] GameObject FPS;
    [SerializeField] GameObject kamaz;
    
    bool f = false;

    [SerializeField] GameObject kamaz_boxCol_hedge;

    private void Start()
    {
        //kamaz.GetComponent<Rigidbody>().freezeRotation = true;
        kamaz.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void Update()
    {
        if(f == true && Input.GetKeyDown(KeyCode.E))
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            kamaz.GetComponent<Rigidbody>().isKinematic = false;
            FPS.SetActive(false);
            kamaz_cam.SetActive(true);
            kamaz.GetComponent<CarControler>().enabled = true;
            kamaz.GetComponent<AudioSource>().enabled = true;
            //kamaz.GetComponent<Rigidbody>().freezeRotation = false;
            this.GetComponent<BoxCollider>().enabled = false;
            kamaz_boxCol_hedge.SetActive(false);
        }   
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "FPS" || col.tag == "Player")
        {
            f = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "FPS" || col.tag == "Player")
        {
            f = false;
        }
    }
}
