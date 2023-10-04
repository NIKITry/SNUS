using UnityEngine;

namespace Script.person_controllers

{ 
    public class PersonController : MonoBehaviour
    {
        private float speed = 2f;
        private float gravity = 20f;
        private Vector3 direction;
        private CharacterController controller;
        
    
        // Start is called before the first frame update
        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            var x = Input.GetAxis("Horizontal");
            var z = Input.GetAxis("Vertical");

            if (controller.isGrounded)
            {
                direction = new Vector3(x, 0f, z);
                direction = transform.TransformDirection(direction) * speed;
            }

            direction.y -= gravity * Time.deltaTime;
            controller.Move(direction * Time.deltaTime);
        }
    }
}
