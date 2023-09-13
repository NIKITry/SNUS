using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FPSCONROL : MonoBehaviour
{
   // public GameObject body;
    private  CharacterController controller;
    public float speed = 6.0f;
    public float gravitat = -9.81f;
    public float h = 5f;
    public Transform Check;
    public float Dis = 0.4f;
    public LayerMask Mask;

   // public GameObject cam1, cam2;
    Vector3 velocity;
    bool endground;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 15.0f;
        else
            speed = 6.0f;

        //endground = Physics.CheckSphere(Check.position, Dis, Mask);

        if (endground && velocity.y < 0)
            velocity.y = -1.25f;

        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

      //  movement.y = gravitat;
        movement *= Time.deltaTime;

        movement = transform.TransformDirection(movement);
        controller.Move(movement);

        if (Input.GetKeyDown(KeyCode.Space) && endground)
            velocity.y += Mathf.Sqrt(h * -1.25f * gravitat);

        velocity.y += gravitat * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime); 

        /* endground = Physics.CheckSphere(Check.position, Dis, Mask);

         if (endground && velocity.y < 0)
             velocity.y = -2f;

         float x = Input.GetAxis("Horizontal");
         float z = Input.GetAxis("Vertical");

         Vector3 move = (transform.right * x) + (transform.forward * z);

         if (Input.GetButtonDown("Jump") && endground)
             velocity.y += Mathf.Sqrt(h * -2f * gravitat);

         controller.Move(move * speed * Time.deltaTime);
         velocity.y += gravitat * Time.deltaTime;
         controller.Move(velocity * Time.deltaTime); */
    }




}
