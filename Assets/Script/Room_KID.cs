using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_KID : MonoBehaviour
{
    [SerializeField] GameObject go, go_1;
    public Transform RotatOpen, RotatOpen_1;
    public float speed;
    public Transform Rotat0;
    public GameObject Man;
    public static bool enter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(enter == true)
        {
            Vector3 direction = Rotat0.transform.position - go.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            go.transform.rotation = Quaternion.Lerp(go.transform.rotation, rotation, speed * Time.deltaTime);
        }

        if (enter == false)
        {
            Vector3 direction = RotatOpen.transform.position - go.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            go.transform.rotation = Quaternion.Lerp(go.transform.rotation, rotation, speed * Time.deltaTime);

            if (VIdeo_end.i == 2)
            {
                Vector3 direction_1 = RotatOpen_1.transform.position - go_1.transform.position;
                Quaternion rotation_1 = Quaternion.LookRotation(direction_1);
                go_1.transform.rotation = Quaternion.Lerp(go_1.transform.rotation, rotation_1, speed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = true;
            Man.GetComponent<RayCastCamera>().enabled = false;

            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
        }
    }
}
