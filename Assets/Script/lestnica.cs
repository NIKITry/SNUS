using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lestnica : MonoBehaviour
{
    public float speed = 5.0f;

    private CharacterController controller;
    private Vector3 moveDir = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        moveDir = transform.TransformDirection(moveDir);
        moveDir *= speed;

        controller.Move(moveDir * Time.deltaTime);
    }





























   


}
