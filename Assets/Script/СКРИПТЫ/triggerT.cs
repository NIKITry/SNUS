using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerT : MonoBehaviour
{
    public GameObject Arrows;
    public GameObject Man;
    public KeyCode najatieT = KeyCode.T;
    public GameObject canvas;
    public GameObject obj;
    public GameObject checpoint;
   // public GameObject Zanovo;
   // public health health;
    public bool enter;
    public void Start()
    {
        enter = false;
        checpoint.GetComponent<shlacbaum_NORMAL>().enabled = false;
        Arrows.SetActive(false);
        Man.GetComponent<Odejda_dly_geroy>().enabled = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
      
    }
    protected virtual void NajatieT()
    {
        if (Input.GetKeyDown(najatieT))
            Form1_KeyDown7();
    }
    protected virtual void Update()
    {
        

        NajatieT();
    }
   
    private void Form1_KeyDown7()
    {
        canvas.SetActive(false);
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.tag == "Player")
        {
            enter = true;
            canvas.SetActive(true);
            obj.SetActive(false);
          //  checpoint.GetComponent<shlacbaum_NORMAL>().enabled = true;
            Arrows.SetActive(true);
            Man.GetComponent<Odejda_dly_geroy>().enabled = true;



        }
    }
   void OnTriggerExit(Collider myTrigger)
    {
        if (myTrigger.tag == "Player")
        {
            enter = false;
            canvas.SetActive(false);
       
        }
    }
}

