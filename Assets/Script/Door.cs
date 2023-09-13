using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float speed = 1f;
    [SerializeField] GameObject go;
    
    public bool enter;

    public Transform RotatOpen;
   
    public Transform Rotat0;
    // Start is called before the first frame update
    void Start()
    {
        go.transform.LookAt(Rotat0);
    }

    // Update is called once per frame
    void Update()
    {

        if (enter == true)
        {

            Vector3 direction = RotatOpen.transform.position - go.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            go.transform.rotation = Quaternion.Lerp(go.transform.rotation, rotation, speed * Time.deltaTime);



        }


        if (enter == false)
        {
            Vector3 direction = Rotat0.transform.position - go.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            go.transform.rotation = Quaternion.Lerp(go.transform.rotation, rotation, speed * Time.deltaTime);

            
            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enter = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
        }
    }
}
