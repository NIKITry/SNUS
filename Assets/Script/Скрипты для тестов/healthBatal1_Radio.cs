using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBatal1_Radio : MonoBehaviour
{

    public static int proideno;
    public int shetchik;
    public int pravilno;
    public int Vibor_testa;
    public GameObject test;
    public GameObject Box;
    public GameObject Р_187П_1;
    public GameObject Р_168_5КН;
    public GameObject Р_168_УН_1;
    public GameObject TA_88;
    public GameObject P_380;
    public GameObject Р_166_05;
    public GameObject way_to_battel;
    public GameObject TriggTest;
    public GameObject img1;
    public GameObject img1_5;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject img6;
    public GameObject img7;
    public GameObject pozdravlenie;
    public static int k1 = 0;
    public static int k2 = 0;
    public static int k3 = 0;
    public static int k4 = 0;
    public static int k5 = 0;
    public static int k6 = 0;


    public void shcet()
    {
        shetchik++;
    }

    public void Pravilno()
    {
        pravilno++;
    }

    public void Test1()
    {
        Vibor_testa = 1;
    }

    public void Test2()
    {
        Vibor_testa = 2;
    }

    public void Test3()
    {
        Vibor_testa = 3;
    }

    public void Test4()
    {
        Vibor_testa = 4;
    }

    public void Test5()
    {
        Vibor_testa = 5;
        
    }
    public void Test6()
    {
        Vibor_testa = 6;

    }



    public void Reshenie()
    {
        if (shetchik == pravilno)
        {
            proideno++;
           
            if (Vibor_testa == 1)
            {
                Destroy(Р_187П_1);
                health.xp += 50;
                health.min_xp += 50;
                k1++;
            }
            if (Vibor_testa == 2)
            {
                Destroy(Р_168_5КН);
                health.xp += 50;
                health.min_xp += 50;
                k2++;
            }
            if (Vibor_testa == 3)
            {
                Destroy(Р_168_УН_1);
                health.xp += 50;
                health.min_xp += 50;
                k3++;
            }

            if (Vibor_testa == 4)
            {
                Destroy(TA_88);
                health.xp += 50;
                health.min_xp += 50;
                k4++;
            }

            if (Vibor_testa == 5)
            {
                Destroy(P_380);
                health.xp += 100;
                health.min_xp += 100;
                k5++;
            }
            if (Vibor_testa == 6)
            {
                Destroy(Р_166_05);
                health.xp += 100;
                health.min_xp += 100;
                k6++;
            }


            if (proideno == 2)
            {
                Box.SetActive(true);
                StartCoroutine(Komanda());
            }
            if (proideno == 6)
            {
                StartCoroutine(Pozdravlenie());
              //  TriggTest.SetActive(false);
               // Cursor.visible = false;
               // Cursor.lockState = CursorLockMode.Locked;
            }
        }
        shetchik = 0;
        pravilno = 0;

    }
    private void Update()
    {
        if (test.activeSelf)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (health.max_xp - health.min_xp <= 0) 
        {
            health.lvl++;
            health.max_xp += 100;

        }

        if(k1 != 0)
        {
            Destroy(Р_187П_1);
        }

        if (k2 != 0)
        {
            Destroy(Р_168_5КН);
        }

        if (k3 != 0)
        {
            Destroy(Р_168_УН_1);
      
        }

        if (k4 != 0)
        {
            Destroy(TA_88);
        }

        if (k5 != 0)
        {
            Destroy(P_380);
        }
        if (k6 != 0)
        {
            Destroy(Р_166_05);
        }



        if (health.lvl != 1)
        {
            img1.SetActive(false);
        }
        if (health.lvl == 2)
        {
            img1.SetActive(false);
            img1_5.SetActive(true);
        }
        if (health.lvl == 3)
        {
            img1_5.SetActive(false);
            img2.SetActive(true);
        }
        if (health.lvl == 4)
        {
            img2.SetActive(false);
            img3.SetActive(true);
        }
        if (health.lvl == 5)
        {
            img3.SetActive(false);
            img4.SetActive(true);
        }
        if (health.lvl == 6)
        {
            img4.SetActive(false);
            img5.SetActive(true);
        }
        if (health.lvl == 7)
        {
            img5.SetActive(false);
            img6.SetActive(true);
        }
        if (health.lvl == 8)
        {
            img6.SetActive(false);
            img7.SetActive(true);
        }


    }
    IEnumerator Komanda()
    {
        way_to_battel.SetActive(true);
        yield return new WaitForSeconds(8f);
        way_to_battel.SetActive(false);
    }

    IEnumerator Pozdravlenie()
    {
       
        pozdravlenie.SetActive(true);
        yield return new WaitForSeconds(15f);
        pozdravlenie.SetActive(false);
    }
}

