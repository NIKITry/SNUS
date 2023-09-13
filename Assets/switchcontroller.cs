using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class switchcontroller : MonoBehaviour
{
    public GameObject firstPersonController;
    public GameObject thirdPersonController;
    //float switchDelay = 0.12f;


    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.O))
        {

            //switchDelay -= Time.deltaTime;
            //if (switchDelay <= 0)
            //{
                firstPersonController.SetActive(!firstPersonController.activeSelf);
                thirdPersonController.SetActive(!thirdPersonController.activeSelf);

                if (firstPersonController.activeSelf)
                {
                    firstPersonController.transform.position = thirdPersonController.transform.position;
                    firstPersonController.transform.rotation = thirdPersonController.transform.rotation;
                }
                else
                {
                    thirdPersonController.transform.position = firstPersonController.transform.position;
                    thirdPersonController.transform.rotation = firstPersonController.transform.rotation;
                }
            //    switchDelay = 0.12f;
            //}

        }
    }
}