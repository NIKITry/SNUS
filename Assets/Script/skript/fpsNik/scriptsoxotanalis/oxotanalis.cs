using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxotanalis : MonoBehaviour
{
    //публикуем
    Animator animator;
    float Velocityz = 0.0f;
    float Velocityx = 0.0f;
    float VelocityZ = 0.0f;
    float VelocityX = 0.0f;
    public float acceleration = 0.2f; 
    public float decceleration = 0.2f;
    public float crouchacceleration = 0.1f;
    public float crouchdeacceleration = 0.1f;
    public float maximumwalkVelocity = 0.1f;
    public float maximumrunVelocity = 0.2f;
    public ray ray;

   public int handup;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        handup = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // ключ для клавиш
        bool walkPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool runPressed = Input.GetKey("left shift");
        bool walkbackPressed = Input.GetKey("s");

       // if (Input.GetKeyDown(KeyCode.Space))
      //  {
       //     animator.SetBool("jump", true);
      //  }
      //  else if (Input.GetKeyUp(KeyCode.Space))
       // {
       //     animator.SetBool("jump", false);
      //  }







        if (runPressed && walkPressed)
        {
            animator.SetBool("run", true);
        }
        else if (!runPressed || !walkPressed)
        {
            animator.SetBool("run", false);

        }

        
    /*    if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            animator.SetBool("runleft", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKey(KeyCode.A))
        {
            animator.SetBool("runleft", false);
        }

        
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            animator.SetBool("runright", true);
        }
       else  if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("runright", false);
        }

        
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
        {
            animator.SetBool("runback", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKey(KeyCode.S))
        {
            animator.SetBool("runback", false); 
        } */

         



        //поднимание руки
        if (Input.GetKeyDown(KeyCode.Q) && handup == 0 )
        {
            gameObject.GetComponent<Animator>().SetTrigger("handup");
            handup = 1;
        }
       else if (Input.GetKeyDown(KeyCode.Q) && handup == 1)
        {
            gameObject.GetComponent<Animator>().SetTrigger("handdown");

            handup = 0;
        }


        // максимальный бег и пресидание
      float currentMaxVelocity = runPressed ? maximumrunVelocity : maximumwalkVelocity;
        
        //взаимодействие с анимацией

        // приседание
        if (Input.GetKey(KeyCode.LeftControl) || ray.flag == true)
        {           
            animator.SetBool("walk_crouch", true);
            if (ray.flag == true)
                animator.SetBool("walk_crouch", true);


        }
       else  if (!Input.GetKeyUp(KeyCode.LeftControl))
        {
            if (ray.flag == false)
            {
                animator.SetBool("walk_crouch", false);
            }
        }

        //ходьба в приседе
       if (walkPressed && VelocityZ < currentMaxVelocity)
        {
            VelocityZ += Time.deltaTime * acceleration;
        }
        if (walkbackPressed && VelocityZ > -currentMaxVelocity)
        {
            VelocityZ -= Time.deltaTime * acceleration;
        }
        if (leftPressed && VelocityX > -currentMaxVelocity)
        {
            VelocityX -= Time.deltaTime * acceleration;
        }
        if (rightPressed && VelocityX < currentMaxVelocity)
        {
            VelocityX += Time.deltaTime * acceleration;
        }

        //ходьба и бег
        if (walkPressed && Velocityz < currentMaxVelocity )
        {
            Velocityz += Time.deltaTime * acceleration;        
        }
        if (walkbackPressed && Velocityz > -currentMaxVelocity)
        {
            Velocityz -= Time.deltaTime * acceleration;            
        }
        if (leftPressed && Velocityx > -currentMaxVelocity)
        {
           Velocityx -= Time.deltaTime * acceleration;
        }
        if (rightPressed && Velocityx < currentMaxVelocity )
        {
            Velocityx += Time.deltaTime * acceleration;
        }

        //ограничение на координатной плоскости ходьба и бег
        if (!walkPressed && Velocityz > 0.0f)
        {
            Velocityz -= Time.deltaTime * crouchdeacceleration;
        }
       if (!walkbackPressed && Velocityz < 0.0f)
        {
            Velocityz += Time.deltaTime * crouchdeacceleration;
        }
        if (!leftPressed && Velocityx < 0.0f)
        {
            Velocityx += Time.deltaTime * crouchdeacceleration;
        }
        if (!rightPressed && Velocityx > 0.0f)
        {
            Velocityx -= Time.deltaTime * crouchdeacceleration;
        }
        if (!leftPressed && !rightPressed && Velocityx != 0.0f && (Velocityx > -0.05f && Velocityx < -0.05f))
        {
            Velocityx = 0.0f;
        }

        //ограничение на координатной плоскости присед
        if (!walkPressed && VelocityZ > 0.0f)
        {
            VelocityZ -= Time.deltaTime * decceleration;
        }
        if (!walkbackPressed && VelocityZ < 0.0f)
        {
            VelocityZ += Time.deltaTime * decceleration;
        }
        if (!leftPressed && VelocityX < 0.0f)
        {
            VelocityX += Time.deltaTime * decceleration;
        }
        if (!rightPressed && VelocityX > 0.0f)
        {
            VelocityX -= Time.deltaTime * decceleration;
        }
        if (!leftPressed && !rightPressed && VelocityX != 0.0f && (VelocityX > -0.05f && VelocityX < -0.05f))
        {
            VelocityX = 0.0f;
        }

/*
        //бег
        if (walkPressed && runPressed && Velocityz > currentMaxVelocity)
        {
            Velocityz = currentMaxVelocity;
        }
        else  if (walkPressed && Velocityz > currentMaxVelocity)
        {
            Velocityz -= Time.deltaTime * decceleration;
            if (Velocityz > currentMaxVelocity && Velocityz < (currentMaxVelocity + 0.05f))
            {
                Velocityz = currentMaxVelocity;
            }
        }

        else if (walkPressed && Velocityz < currentMaxVelocity && Velocityz > (currentMaxVelocity - 0.05f) )
        {
            Velocityz = currentMaxVelocity;
        }

        //бег назад
        if (walkbackPressed && runPressed && Velocityz < -currentMaxVelocity)
        {
            Velocityz = -currentMaxVelocity;
        }
        else if (walkbackPressed && Velocityz < -currentMaxVelocity)
        {
            Velocityz += Time.deltaTime * decceleration;
            if (Velocityz < -currentMaxVelocity && Velocityz > (-currentMaxVelocity - 0.05f))
            {
                Velocityz = -currentMaxVelocity;
            }
        }

        else if (walkbackPressed && Velocityz > -currentMaxVelocity && Velocityz < (-currentMaxVelocity + 0.05f))
        {
            Velocityz = -currentMaxVelocity;
        }


        // налево
        if (leftPressed && runPressed && Velocityx < -currentMaxVelocity)
        {
            Velocityx = -currentMaxVelocity;
        }
        else if (leftPressed && Velocityx < -currentMaxVelocity)
        {
            Velocityx += Time.deltaTime * decceleration;
            if (Velocityz < -currentMaxVelocity && Velocityx > (-currentMaxVelocity - 0.05f))
            {
                Velocityx = -currentMaxVelocity;
            }
        }

        else if (leftPressed && Velocityx > -currentMaxVelocity && Velocityx < (-currentMaxVelocity + 0.05f))
        {
            Velocityx = -currentMaxVelocity;
        }

        // направо
        if (rightPressed && runPressed && Velocityx > currentMaxVelocity)
        {
            Velocityx = currentMaxVelocity;
        }
        else if (rightPressed && Velocityx > currentMaxVelocity)
        {
            Velocityx -= Time.deltaTime * decceleration;
            if (Velocityz > currentMaxVelocity && Velocityx < (currentMaxVelocity + 0.05f))
            {
                Velocityx = currentMaxVelocity;
            }
        }

        else if (rightPressed && Velocityx < currentMaxVelocity && Velocityx > (currentMaxVelocity - 0.05f))
        {
            Velocityx = currentMaxVelocity;
        }

      

        else if (walkPressed && Velocityz < currentMaxVelocity && Velocityz > (currentMaxVelocity - 0.05f))
        {
            Velocityz = currentMaxVelocity;
        }
*/


        //бег(присед)
        if (walkPressed && runPressed && VelocityZ > currentMaxVelocity)
        {
            VelocityZ = currentMaxVelocity;
        }
        else if (walkPressed && VelocityZ > currentMaxVelocity)
        {
            VelocityZ -= Time.deltaTime * decceleration;
            if (VelocityZ > currentMaxVelocity && VelocityZ < (currentMaxVelocity + 0.05f))
            {
                VelocityZ = currentMaxVelocity;
            }
        }

        else if (walkPressed && VelocityZ < currentMaxVelocity && VelocityZ > (currentMaxVelocity - 0.05f))
        {
            VelocityZ = currentMaxVelocity;
        }

        //бег назад (присед)
        if (walkbackPressed && runPressed && VelocityZ < -currentMaxVelocity)
        {
            VelocityZ = -currentMaxVelocity;
        }
        else if (walkbackPressed && VelocityZ < -currentMaxVelocity)
        {
            VelocityZ += Time.deltaTime * decceleration;
            if (VelocityZ < -currentMaxVelocity && VelocityZ > (-currentMaxVelocity - 0.05f))
            {
                VelocityZ = -currentMaxVelocity;
            }
        }

        else if (walkbackPressed && VelocityZ > -currentMaxVelocity && VelocityZ < (-currentMaxVelocity + 0.05f))
        {
            VelocityZ = -currentMaxVelocity;
        }


        // налево (присед)
        if (leftPressed && runPressed && VelocityX < -currentMaxVelocity)
        {
            VelocityX = -currentMaxVelocity;
        }
        else if (leftPressed && VelocityX < -currentMaxVelocity)
        {
            VelocityX += Time.deltaTime * decceleration;
            if (VelocityZ < -currentMaxVelocity && VelocityX > (-currentMaxVelocity - 0.05f))
            {
                VelocityX = -currentMaxVelocity;
            }
        }

        else if (leftPressed && VelocityX > -currentMaxVelocity && VelocityX < (-currentMaxVelocity + 0.05f))
        {
            VelocityX = -currentMaxVelocity;
        }

        // направо (присед)
        if (rightPressed && runPressed && VelocityX > currentMaxVelocity)
        {
            VelocityX = currentMaxVelocity;
        }
        else if (rightPressed && VelocityX > currentMaxVelocity)
        {
            VelocityX -= Time.deltaTime * decceleration;
            if (VelocityZ > currentMaxVelocity && VelocityX < (currentMaxVelocity + 0.05f))
            {
                VelocityX = currentMaxVelocity;
            }
        }

        else if (rightPressed && VelocityX < currentMaxVelocity && VelocityX > (currentMaxVelocity - 0.05f))
        {
            VelocityX = currentMaxVelocity;
        }



        else if (walkPressed && VelocityZ < currentMaxVelocity && VelocityZ > (currentMaxVelocity - 0.05f))
        {
            VelocityZ = currentMaxVelocity;
        }


        animator.SetFloat("Velocityz", Velocityz);
        animator.SetFloat("Velocityx", Velocityx);
        animator.SetFloat("VelocityZ", VelocityZ);
        animator.SetFloat("VelocityX", VelocityX);

    }
}
