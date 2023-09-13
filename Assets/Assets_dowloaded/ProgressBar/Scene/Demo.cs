using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour {

    public ProgressBar Pb, PbC;
   

    private void Start()
    {
        Pb.BarValue = 100;
       // PbC.BarValue = 100;
    }

    void FixedUpdate () {
		
        if(Input.GetKey(KeyCode.Mouse0))
        {
            Pb.BarValue += 1;
           // PbC.BarValue += 1;
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            Pb.BarValue -= 1;
          //  PbC.BarValue -= 1;
        }
    }
}
