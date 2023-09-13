using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class playercontroler : MonoBehaviour
{
	// public GameObject body;
	private CharacterController controller;
	

	
	public float gravitat = -9.81f;
	public float h = 5f;
	public Transform Check;
	public float Dis = 0.4f;
	public LayerMask Mask;
	public bool isground;
	public ray ray;
	public float maxSpeed = 10f;
	public float minSpeed = 6f;
	public float acceleration = 0.2f;
	public float speed = 0;
    bool shift;
	bool wasd;
	bool ws;
	int w_s = 0;
	bool ad;
	int a_d = 0;
	public CharacterController player;

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
		
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
			wasd = true;
		else
			wasd = false;

		// бег вперед назад
		if (Input.GetKey(KeyCode.W))
		{
			ws = true;
			
		}

		if (Input.GetKey(KeyCode.S))
		{
			ws = false;
			
		}

		if (ws == true && w_s == 0)
		{
			speed = 0;
			w_s = 1;
		}
		if (ws == false && w_s == 1)
		{
			speed = 0;
			w_s = 0;
		}

		//бег в лево в право
		if (Input.GetKey(KeyCode.A))
		{
			ad = true;

		}

		if (Input.GetKey(KeyCode.D))
		{
			ad = false;

		}

		if (ad == true && a_d == 0)
		{
			speed = 0;
			a_d = 1;
		}
		if (ad == false && a_d == 1)
		{
			speed = 0;
			a_d = 0;
		}


		if (Input.GetKey(KeyCode.LeftShift))
			shift = true;
		else
			shift = false;

		if (speed >= maxSpeed)
			speed = maxSpeed;

		if (speed == minSpeed)
			speed = minSpeed;

		if (Input.GetKey(KeyCode.LeftShift))
			speed += acceleration;

		 if (speed > minSpeed && shift ==  false)
		     speed -= acceleration;

		if (wasd == true && speed < minSpeed)
			speed += acceleration;

		if (wasd == false && speed > 0)
			speed -= acceleration;

		

		endground = Physics.CheckSphere(Check.position, Dis, Mask);

		if (endground && velocity.y < 0)
			velocity.y = -1.25f;

		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;

		Vector3 movement = new Vector3(deltaX, 0, deltaZ);
		movement = Vector3.ClampMagnitude(movement, speed);

		// movement.y = gravitat;
		movement *= Time.deltaTime;

		movement = transform.TransformDirection(movement);
		controller.Move(movement);

		if (Input.GetButtonDown("Jump") && endground)
			velocity.y += Mathf.Sqrt(h * -1.25f * gravitat);

		velocity.y += gravitat * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime);




		// присидание
		if (!Input.GetKey(KeyCode.LeftControl))
		{
			if (ray.flag == false)
			{
				player.height = 35.66f;
			}
		}

		else if (Input.GetKey(KeyCode.LeftControl) || ray.flag == true)
		{
			player.height = 29f;

			if (ray.flag == true)
				player.height = 29f;

		}

		/*if (Input.GetKeyUp(KeyCode.LeftControl) ) 
		{ 		
		player.center = new Vector3(player.center.x, 19f, 0f);
		}

		if (!Input.GetKey(KeyCode.LeftControl) && ray.flag == false)
		{
			player.center = new Vector3(player.center.x, 19f, 0f);
		}


		else if (Input.GetKey(KeyCode.LeftControl) || ray.flag == true)
		{
			player.center = new Vector3(player.center.x, 15.3f , 4.5f);
			if (ray.flag == true)
				player.center = new Vector3(player.center.x, 15.3f, 4.5f);			
		}


		//прыжок
				/*if (Input.GetKey(KeyCode.Space))
        {
			player.center = new Vector3(player.center.x, 30f, player.center.z);
		}
		else if (Input.GetKeyUp(KeyCode.Space))
        {
			StartCoroutine(zadershka());
        }
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
/*
    IEnumerator zadershka()
    {

		yield return new WaitForSeconds(1f);
		player.center = new Vector3(player.center.x, 19f, player.center.z);
	}
	*/
}

