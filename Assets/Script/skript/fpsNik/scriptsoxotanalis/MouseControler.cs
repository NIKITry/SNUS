using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControler : MonoBehaviour
{

	private Vector3 Rot;
	private float xRot;
	private float yRot;
	private float xCurrRot;
	private float yCurrRot;
	[SerializeField]
	private Camera fpcCamera;
	[SerializeField]
	private GameObject fpcObject;
	public float mouseSensetive;
	private float xRotVelocity;
	private float yRotVelocity;
	[SerializeField]
	private float smoothDampTime = 0.1f;



	// Use this for initialization
	void Start()
	{
		mouseSensetive = 5f;
	}

	// Update is called once per frame
	void Update()
	{
		MouseMove();
	}

	private void MouseMove()
	{
		xRot -= Input.GetAxis("Mouse Y") * mouseSensetive;
		yRot += Input.GetAxis("Mouse X") * mouseSensetive;
		xRot = Mathf.Clamp(xRot, -70, 69);

		xCurrRot = Mathf.SmoothDamp(xCurrRot, xRot, ref xRotVelocity, smoothDampTime);
		yCurrRot = Mathf.SmoothDamp(yCurrRot, yRot, ref yRotVelocity, smoothDampTime);

		fpcCamera.transform.rotation = Quaternion.Euler(xCurrRot, yCurrRot, 0f);
		fpcObject.transform.rotation = Quaternion.Euler(0f, yCurrRot, 0f);

	}
}
