using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BiG_Quest_2 : MonoBehaviour
{
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

    int i = 0;
    int j = 0;
    // Start is called before the first frame update

    void Start()
    {
        j = 0;
        i = 0;
        tmp = 0;
        if (Fps_1.activeSelf)
        {
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

        Debug.Log(tmp);


        if (Clider_Conrol.koef == 8 && flag[0] == false)
        {
            StartCoroutine(izuchenie_TTX());
        }

        if (tmp == 4 && flag[1] == false)
        {
            StartCoroutine(izuchenie_YC());
        }




        if (healthBatal1_Radio.proideno == 6 && krest[0] == false)
        {
            StartCoroutine(Yc_komand_test_all());
        }


    }



    IEnumerator Shlak()
    {
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
    }
    IEnumerator Yc_komand()
    {
        Quest[i].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest[i].SetActive(false);
        i = 3;
        Quest[i].SetActive(true);
        Questing_2.SetActive(true);
        flag[2] = true;
        A = 3;
    }
    IEnumerator izuchenie_TTX()
    {
        Quest[i].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest[i].SetActive(false);
        i = 1;
        Quest[i].SetActive(true);
        Questing_2.SetActive(true);
        flag[0] = true;
        A = 4;
    }
    IEnumerator izuchenie_YC()
    {
        Quest[i].GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(1.0f);
        Quest[i].SetActive(false);
        i = 2;
        Quest[i].SetActive(true);

        flag[1] = true;
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
        j = 1;
        Quest_2[j].SetActive(true);

        krest[0] = true;
    }
}
