using UnityEngine;
using System.Collections;

class shlacbaum_NORMAL : MonoBehaviour
{
   
    public float speed = 1f;
    [SerializeField] GameObject go;
    public float raz = 2;
    
    
    int k = 0;
    public Transform targetup;
    public Transform target0;

    private void Start()
    {

        
        go.transform.LookAt(target0);
       

    }
    void Update()
    {

        if (k == 1)
        {
            
            Vector3 direction = targetup.transform.position - go.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            go.transform.rotation = Quaternion.Lerp(go.transform.rotation, rotation, speed * Time.deltaTime);



        }


        if (k == 0)
        {
            Vector3 direction = target0.transform.position - go.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            go.transform.rotation = Quaternion.Lerp(go.transform.rotation, rotation, speed * Time.deltaTime);

        }
        }
   

    


    void OnTriggerEnter(Collider col)
    {

        k = 1;

    }
    private void OnTriggerExit(Collider col)
    {

        k = 0;
    }

}