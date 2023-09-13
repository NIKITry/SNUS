using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class тело : MonoBehaviour
{
   public Camera Golova;
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2,

    }
    public RotationAxes axes = RotationAxes.MouseXAndY;

    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minimumVert = -65.0f;
    public float maximumVert = 65.0f;

    private float _rotationX = 0;

    public float mouseSen = 100f;
    public float speed = 2f;

   // public Transform Body;



    float xRot = 0f;

    void Start()
    {
       /* Rigidbody body = GetComponent<Rigitbody>();
        if (body != null)
            body.freezeRotation = true;*/
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Golova.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50) && hit.collider.tag == "Morze" && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Transform objectHit = hit.transform;
            SceneManager.LoadScene("Scene_2_2");
            Debug.Log("WOOOW");


        }

        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }

        else
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
           //Body.Rotate(Vector3.up * _rotationX);
        }
      /*  float mouseX = Input.GetAxis("Mouse X") * mouseSen * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSen * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        Body.Rotate(Vector3.up * mouseX); */



    }




}