using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting_new : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("IsShooting", true);
        }
        else
        {
            animator.SetBool("IsShooting", false);
        }
    }

}
