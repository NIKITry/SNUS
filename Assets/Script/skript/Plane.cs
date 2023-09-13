using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject plane;
  
    public float speed;
    
  
 

    
    // Update is called once per frame
    void Update()
    {
        plane.transform.Translate(Vector3.up * speed * Time.deltaTime);

       

    }

   
  



}
