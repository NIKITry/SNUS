using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Diagnostics;

public class BiG_Quest : MonoBehaviour
{
    public Odejda_dly_geroy odejda;
    public Quest_Trigg_shlak shlacbaum;
    public triggerT Voencom;
    public Activ_sript YC_nashli;
    public GameObject Fps_1;

     bool[] flag = null;
     bool[] krest = null;
    public int n;
    public static int A = 0;
    public static int tmp;


    public GameObject[] Quest;
    public GameObject[] Quest_2;

    public GameObject Questing_2;

   public  int i = 0;
   public  int j = 0;
    // Start is called before the first frame update

   public void Start()
    {
     
        tmp = 0;
        if (Fps_1.activeSelf)
        {
            if (i != 0)
                i = 0;
            if (j != 0)
                j = 0;
            flag = new bool[n];
            krest = new bool[n];
            for (int i = 0; i < n; i++)
            {
                flag[i] = false;
                krest[i] = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (shlacbaum.enter_shlak == true && flag[0] == false )
        {
            StartCoroutine(Shlak());
        }



        if (Voencom.enter == true && flag[1] == false )
        {
            StartCoroutine(Voencommat());
        }

        if (Odejda_dly_geroy.n == odejda.odejda.Length && flag[2] == false)
        {
            StartCoroutine(Odejda());
        }



        if (YC_nashli.enter == true && flag[3] == false)
        {
            StartCoroutine(Yc_komand());
        }


        if (Clider_Conrol.koef == 8 && flag[4] == false)
        {
            StartCoroutine(izuchenie_TTX());
        }

       /* if (tmp == 4 && flag[5] == false )
        {
            StartCoroutine(izuchenie_YC());
        }*/



        if (healthBatal1_Radio.proideno == 1 && krest[0] == false)
        {
            StartCoroutine(Yc_komand_test_1());
        }



        if (healthBatal1_Radio.proideno == 6 && krest[1] == false)
        {
            StartCoroutine(Yc_komand_test_all());
        }

       
    }

    

    IEnumerator Shlak() {
        Quest[i].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest[i].SetActive(false);
        i = 1;
        Quest[i].SetActive(true);
        flag[0] = true;
        A = 1;
    }
    IEnumerator Voencommat()
    {
        Quest[i].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest[i].SetActive(false);
        i = 2;
        Quest[i].SetActive(true);
        flag[1] = true;
        A = 2;
        for (int i = 0; i < odejda.odejda.Length; i++) {
            odejda.odejda[i].GetComponent<BoxCollider>().enabled = true;
                }
    }

    IEnumerator Odejda()
    {
        Quest[i].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest[i].SetActive(false);
        i = 3;
        Quest[i].SetActive(true);
        flag[2] = true;
        A = 3;
    }


    IEnumerator Yc_komand()
    {
        Quest[i].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest[i].SetActive(false);
        i = 4;
        Quest[i].SetActive(true);
        Questing_2.SetActive(true);
        flag[3] = true;
        A = 4;
    }
    IEnumerator izuchenie_TTX()
    {
        Quest[i].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest[i].SetActive(false);
        i = 5;
        Quest[i].SetActive(true);
        Questing_2.SetActive(true);
        flag[4] = true;
        A = 5;
    }
    IEnumerator izuchenie_YC()
    {
        Quest[i].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest[i].SetActive(false);
        i = 6;
        Quest[i].SetActive(true);
       
        flag[5] = true;
    }

    IEnumerator Yc_komand_test_1()
    {
        Quest_2[j].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest_2[j].SetActive(false);
        j = 1;
        Quest_2[j].SetActive(true);
       
        krest[0] = true;
    }

    IEnumerator Yc_komand_test_all()
    {
        Quest_2[j].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest_2[j].SetActive(false);
        j = 2;
        Quest_2[j].SetActive(true);
       
        krest[1] = true;
    }
}
