using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raketa : MonoBehaviour
{
    
    public GameObject Zvuk_raketi;
    public GameObject Zvuk_vzriva;
    public GameObject BOOM;
    public GameObject Explosion;
    public Transform plane_this;
    public GameObject bomba;
    public float speed;
    public GameObject plane;
    public GameObject Raketa;
    int k = 0;
    public bool enter;

    // Update is called once per frame
    void Update()
    {

        if (BOOM_plane.enter_out == true)
        {
            Zvuk_raketi.SetActive(true);
            transform.position = Vector3.MoveTowards(transform.position, plane_this.position, speed * Time.deltaTime);
        }
        Vector3 direction = (plane_this.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, direction.y, direction.z));
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed);

        if (plane.transform.position == Raketa.transform.position && k == 0)
        {

            StartCoroutine(Komanda());
        }
    }
    IEnumerator Komanda()
    {
        
        Explosion.SetActive(true);
        Explosion.GetComponent<MeshRenderer>().enabled = false;
        BiG_Quest.tmp++;
        yield return new WaitForSeconds(0.01f);
        Explosion.GetComponent<MeshRenderer>().enabled = true;
        Zvuk_vzriva.SetActive(true);
        BOOM.GetComponent<Plane>().enabled = false;
        plane.GetComponent<Plane>().enabled = false;
      
        plane.SetActive(false);
        Raketa.SetActive(false);
           if(Bomba.kinematik_flag == 0)
        {
            bomba.SetActive(false);
        }
        yield return new WaitForSeconds(2.0f);

        k = 1;
    }

    
   
 
}

