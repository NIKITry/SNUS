using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Ladder: MonoBehaviour {
	bool enter;
	private bool State1 = true;
	private bool State2 = false;
	private bool State3 = false;

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift) && enter == true)
        {
			State1 = !State1;
			State2 = !State2;
			State3 = !State3;
			GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().enabled = State1;
			GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>().enabled = State2;
			GameObject.FindGameObjectWithTag("Player").GetComponent<lestnica>().enabled = State3;
		}
		if(enter == false && Finish_polosa_zachet.enter == false)
        {
			GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().enabled = true;
			GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>().enabled = false;
			GameObject.FindGameObjectWithTag("Player").GetComponent<lestnica>().enabled = false;
		}
    }
    void OnTriggerEnter(Collider other) {
	
		if (other.tag == "Player"){
			enter = true;
			
		}
	}
	
	void OnTriggerExit(Collider other) {

		if (other.tag == "Player")
		{
			enter = false;

		}
	}
}
