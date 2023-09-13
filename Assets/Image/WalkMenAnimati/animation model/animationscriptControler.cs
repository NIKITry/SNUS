using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationscriptControler : MonoBehaviour
{
    Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("iswalk", false);

    }

    // Update is called once per frame
    void Update()
    {
        //Ходьба 
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("iswalk", true);
            Debug.Log("++++CUM++++");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("iswalk", false);
        }
        
        //Бег->Стойка
        else
         if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            animator.SetBool("run_idle", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("run_idle", false);
        }

        //Ходьба->Бег
        else
    if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isrun", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("isrun", false);
        }

        //Стойка->Присед
        else
        if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("iscrouch", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("iscrouch", false);
        }

       //Присед->Ходьба в приседе
        else
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.W))
        {
            animator.SetBool("iscrouchwalk", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("iscrouchwalk", false);
        }

        //ходьба_ходьбаприсед
        else
         if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouch_walk", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("crouch_walk", false);
        }

        //ходьба назад
        else
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("walkback", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("walkback", false);
        }

        //бег назад
        else
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
        {
            animator.SetBool("runback", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("runback", false);
        }

        //бег назад->стойка 
        else
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
        {
            animator.SetBool("runback_idle", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("runback_idle", false);
        }
        
        //ходьба вправо
        else
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("rightwalk", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("rightwalk", false);
        }

        //ходьба влево
        else
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("leftwalk", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("leftwalk", false);
        }
        
        //бег вправо
        else
         if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            animator.SetBool("rightrun", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("rightrun", false);
        }

        //бег вправо->стойка
        else
         if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            animator.SetBool("rightrun_idle", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("rightrun_idle", false);
        }

        //бег влево
        else
         if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            animator.SetBool("leftrun", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("leftrun", false);
        }

        //бег влево->стойка
        else
         if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            animator.SetBool("leftrun_idle", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("leftrun_idle", false);
        }

        //ходьбаприседназад
        else
         if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouchbackwalk", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("crouchbackwalk", false);
        }

        //ходьбаприседназад->стойка
        else
         if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouchwalkback_idle", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("crouchwalkback_idle", false);
        }

        //ходьназад->cприседомходьба
        else
         if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouchbackwalk_back", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("crouchbackwalk_back", false);
        }

        //c приседом ходьба вправо
        else
         if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouchwalkright", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("crouchwalkright", false);
        }
        
        //c приседом ходьба влево
        else
         if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouchwalkleft", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("crouchwalkleft", false);
        }

       
             //c приседом ходьба вправо->ходьба вправо
        else
         if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouchwalkright_rightwalk", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("crouchwalkright_rightwalk", false);
        }

        //c приседом ходьба влево->ходьба влевво
        else
         if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouchleft_left", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("crouchleft_left", false);
        }

    }


}
