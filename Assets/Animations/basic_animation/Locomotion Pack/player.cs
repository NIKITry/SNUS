using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public Animator playerAnim;
	public Rigidbody playerRigid;
	public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;
	public bool walking;
	public Transform playerTrans;
	public float distToGround = 1f;

	[SerializeField] float jumpForce = 200;

	Rigidbody rb;

    private void Start()
    {
		rb = GetComponent<Rigidbody>();
    }

   



    void FixedUpdate()
	{
		GroundCheck();
		if (isGrounded && Input.GetKey(KeyCode.W))
		{
			playerRigid.velocity = transform.forward * w_speed * Time.deltaTime;
		} else
        {
			GroundCheck();
		}
		if (isGrounded && Input.GetKey(KeyCode.S))
		{
			playerRigid.velocity = -transform.forward * wb_speed * Time.deltaTime;
		} else
        {
			GroundCheck();
		}

	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			playerAnim.ResetTrigger("idle");
			playerAnim.SetTrigger("walk");
            walking = true;
			//steps1.SetActive(true);
		}
		if (Input.GetKeyUp(KeyCode.W))
		{
			playerAnim.ResetTrigger("walk");
			playerAnim.SetTrigger("idle");
			walking = false;
			//steps1.SetActive(false);
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			playerAnim.SetTrigger("walkback");
			playerAnim.ResetTrigger("idle");
			//steps1.SetActive(true);
		}
		if (Input.GetKeyUp(KeyCode.S))
		{
			playerAnim.ResetTrigger("walkback");
			playerAnim.SetTrigger("idle");
			//steps1.SetActive(false);
		}
		if (Input.GetKey(KeyCode.A))
		{
			playerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);


		}
		if (Input.GetKey(KeyCode.D))
		{
			playerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);
		}
		if (walking == true)
		{
			if (Input.GetKeyDown(KeyCode.LeftShift))
			{
				//steps1.SetActive(false);
				//steps2.SetActive(true);
				w_speed = w_speed + rn_speed;
				playerAnim.ResetTrigger("walk");
				playerAnim.SetTrigger("run");
			}
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                //steps1.SetActive(true);
                //steps2.SetActive(false);
                w_speed = olw_speed;
                playerAnim.ResetTrigger("run");
                playerAnim.SetTrigger("walk");
            }
        } else
        {
			w_speed = olw_speed;
		}


		if (isGrounded && Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

		}
	

	}

	public bool isGrounded = true;

	void GroundCheck () {

		if(Physics.Raycast(transform.position, Vector3.down, distToGround + 0.05f)) {
			isGrounded = true;
		} else {
			isGrounded = false;
		}
	}
	
}
