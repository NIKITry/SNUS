using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastCamera : MonoBehaviour
{
    public Camera Golova;
    public GameObject[] odejda;
    public GameObject Knopka_RUS, trigger_ojeda;

    [SerializeField] GameObject go;
    public GameObject room_KID;
    public Transform RotatOpen;

    public Transform Rotat0;
    float speed = 1;
    int k = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Golova.ScreenPointToRay(Input.mousePosition);
        for (int i = 0; i < odejda.Length; i++)
        {
            if (Physics.Raycast(ray, out hit, 50) && hit.collider.tag == "Odejda")
            {
                if (hit.collider.gameObject == odejda[i])
                {

                    Knopka_RUS.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {

                        odejda[i].SetActive(false);
                        k++;
                        Knopka_RUS.SetActive(false);

                        
                    }
                }
            }
        }

        if (k == odejda.Length)
        {
            Vector3 direction = Rotat0.transform.position - go.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            go.transform.rotation = Quaternion.Lerp(go.transform.rotation, rotation, speed * Time.deltaTime);
            trigger_ojeda.SetActive(false);

            room_KID.SetActive(true);
        }
    }

}
