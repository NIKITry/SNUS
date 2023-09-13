using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ropePositionTransform : MonoBehaviour
{
    [SerializeField]
    private GameObject[] kolushek;
    [SerializeField]
    private GameObject[] begin;
    [SerializeField]
    private GameObject[] end;
    [SerializeField]
    private GameObject end_Sphere_1;
    [SerializeField]
    private GameObject end_Sphere_2;
    [SerializeField]
    private GameObject end_Sphere_3;

    bool k = false; // antena anim flag

    private void Update()
    {
        for (int i = 0; i < kolushek.Length; i++)
        {
            begin[i].transform.position = new Vector3(kolushek[i].transform.position.x, kolushek[i].transform.position.y, kolushek[i].transform.position.z);
            end[i].transform.position = begin[i].transform.position;
        }

        if (k == true)
        {
            for (int j = 0; j < kolushek.Length; j++)
            {
                if (j <= 2)
                {
                    end[j].transform.position = end_Sphere_1.transform.position;
                }
                else if (3 <= j && j <= 5)
                {
                    end[j].transform.position = end_Sphere_2.transform.position;
                }
                else
                {
                    end[j].transform.position = end_Sphere_3.transform.position;
                }
            }
        }
    }

    void ropeStart()
    {
        k = true;
    }
}
