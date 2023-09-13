using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitInKAMAZ_2 : MonoBehaviour
{
    [SerializeField] GameObject FPS;
    [SerializeField] GameObject kamaz_svertka;
    [SerializeField] GameObject kamaz_R149;

    [SerializeField] GameObject[] element_razvertki;

    [SerializeField] GameObject obi_Solver;
    [SerializeField] GameObject napr5;

    bool enter = false;

    private void Update()
    {
        if(enter == true && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(animStop());
        }
    }

    IEnumerator animStop()
    {
        yield return new WaitForSeconds(2.0f);
        kamaz_R149.SetActive(false);
        kamaz_svertka.SetActive(true);
        FPS.SetActive(false);
        for(int i = 0; i < element_razvertki.Length; i++)
        {
            element_razvertki[i].SetActive(false);
        }
        obi_Solver.SetActive(false);
        napr5.SetActive(true);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            enter = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = false;
        }
    }
}
