using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mine_detector : MonoBehaviour
{ public GameObject detector;
    public GameObject mine_det;
    private GameObject[] mine;
    private float[] Distanation;
    public GameObject zvuk_mine_det;
    public int number_mine;
    public float dist_1;
    public float dist_2;
    public float dist_now;
    public bool punch;
    float dist_min = 300000;
    int fix_number_min;
     void Start()
    {
        detector.SetActive(false);
        zvuk_mine_det.GetComponent<AudioSource>().pitch = 0.5f;
        dist_now = 2f;
       // mine = GameObject.FindGameObjectsWithTag("Mina");
        punch = false;
        Distanation = new float[mine.Length];


        for (int i = 0; i < mine.Length; i++)
        {
            Distanation[i] = 0f;
           // Debug.Log(Distanation[i]);
        }


    }
    
   

// Update is called once per frame
  void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y) && punch == false)
        {
            punch = true ;
            detector.SetActive(true);
        }

       else if (Input.GetKeyDown(KeyCode.Y) && punch == true)
        {
            punch = false;
           detector.SetActive(false);
        }


        // Debug.Losg(mine.Length);

        if (detector.activeSelf)
        for (int i = 0; i < mine.Length; i++)
        {
            dist_1 = Vector3.Distance(mine_det.transform.position, mine[i].transform.position);
            Distanation[i] = dist_1;
           // Debug.Log(Distanation[i]);
            if (dist_min > Distanation[i])
            {
                dist_min = Distanation[i];
                fix_number_min = i;
            }
        }
        dist_2 = Vector3.Distance(mine_det.transform.position, mine[fix_number_min].transform.position);



        if (dist_2 < 2)
        {
            if (dist_now - dist_2 >= 0.01)
            {
                dist_now = dist_2;
                zvuk_mine_det.GetComponent<AudioSource>().pitch += 0.1f;
            }
            if (dist_now - dist_2 <= -0.01)
            {
                dist_now = dist_2;
                zvuk_mine_det.GetComponent<AudioSource>().pitch -= 0.1f;
            }
        }
        if (dist_2 > 2)
        {
            zvuk_mine_det.GetComponent<AudioSource>().pitch = 0.5f;
            dist_now = 2f;
            dist_min = 30000;
        }
    }
}
