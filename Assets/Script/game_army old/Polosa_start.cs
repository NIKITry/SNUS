using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Polosa_start : MonoBehaviour
{
    public FirstPersonController Person;
    public Transform spawn;
    public static int score;
    public GameObject ZACCHET_FIN, Canvas_Polosa, Pravila, Ochet, markerQuest, Text_start;
    public Text otchet;
    public static GameObject[] triggers;
    public static GameObject[] instr;
    public static Trigger_polosa[] polosa;
    bool enter = false;
    bool zachet = false;
    public static bool trennirovka = false;
    public static  bool start = false;
    public static int koef;
    int k = 1;
    public static int sec, min;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        score = 1500;
        GameObject finish_trigg;
        finish_trigg = GameObject.Find("Финиш_зачет(trigg) ");
       // finish_trigg.GetComponent<Finish_polosa_zachet>().enabled = false;
        finish_trigg.SetActive(false);
        // Ochet.SetActive(false);
        koef = 3;
        otchet.text = "" + koef;
        triggers = GameObject.FindGameObjectsWithTag("Polosa");
        polosa = FindObjectsOfType<Trigger_polosa>();
        instr = GameObject.FindGameObjectsWithTag("Polosa_trenirovka");
       
        timerText.gameObject.SetActive(false);
        for (int i = 0; i < triggers.Length; i++)
        {
            triggers[i].SetActive(false);

        }
        for (int i = 0; i < polosa.Length; i++)
        {
            polosa[i].enter = false;
        }
        for (int i = 0; i < instr.Length; i++)
        {
            instr[i].SetActive(false);
        }
        gameObject.GetComponent<SphereCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject man;
        if (enter == true && Input.GetKeyDown(KeyCode.E)) //отключение каммеры и включение канваса с правилами
        {
            Text_start.SetActive(false);
            markerQuest.SetActive(false);
            man = GameObject.FindGameObjectWithTag("Player");
            man.GetComponent<FirstPersonController>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Canvas_Polosa.SetActive(true);


        }

        if (zachet == true) // переход к зачету по полосе препядствий
        {
            for (int i = 0; i < triggers.Length; i++)
            {
                triggers[i].SetActive(true);

            }
            Pravila.SetActive(true);

        }

        if (start == true)
        {
            GameObject finish_trigg;
            finish_trigg = GameObject.Find("Финиш_зачет(trigg) ");
            finish_trigg.GetComponent<Finish_polosa_zachet>().enabled = true;
            zachet = false;
            Pravila.SetActive(false);
            
            if (Ochet.GetComponent<Text>().fontSize >= 10)
            {
                Ochet.GetComponent<Text>().fontSize -= 6;
                if (Ochet.GetComponent<Text>().fontSize < 10)
                {
                    if (otchet.text == "CTAPT" && koef == 1)
                    {
                        Ochet.SetActive(false);
                        StartCoroutine(timer());
                        man = GameObject.FindGameObjectWithTag("Player");
                        man.GetComponent<FirstPersonController>().enabled = true;
                    }
                    Ochet.GetComponent<Text>().fontSize = 230;


                    if (koef > 1)
                    {
                        koef -= 1;
                        otchet.text = "" + koef;
                    }

                    else if (koef == 1)
                    {
                        otchet.text = "CTAPT";
                        man = GameObject.FindGameObjectWithTag("Player");
                        GameObject stena;
                        stena = GameObject.FindGameObjectWithTag("stena");
                        stena.GetComponent<Ladder>().enabled = true;

                    }
                }
            }

        }

        if (trennirovka == true) // переход к треннировке
        {
            man = GameObject.FindGameObjectWithTag("Player");
            man.GetComponent<FirstPersonController>().enabled = true;

            for (int i = 0; i < triggers.Length; i++)
            {
                triggers[i].SetActive(true);

            }
            for (int i = 0; i < instr.Length; i++)
            {
                instr[i].SetActive(true);

            }

        }
        for (int i = 0; i < polosa.Length; i++) // проверка на вход в запретный триггер
        {
            if (polosa[i].enter == true)
            {

                man = GameObject.FindGameObjectWithTag("Player");
                man.transform.position = Vector3.MoveTowards(man.transform.position, spawn.position, 100f);
                polosa[i].enter = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = true;
            Text_start.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enter = false;
            Text_start.SetActive(false);
        }
    }
    public void Zachet()
    {
        
        // finish_trigg.GetComponent<Finish_polosa_zachet>().enabled = false;
        ZACCHET_FIN.SetActive(true);
        Debug.Log("&&&&&&&");
        GameObject man;
        man = GameObject.FindGameObjectWithTag("Player");
        zachet = true;
        Canvas_Polosa.SetActive(false);
        man.transform.position = Vector3.MoveTowards(man.transform.position, spawn.position, 100f);
        Person.walkSpeed = 5;
        GameObject stena;
        stena = GameObject.FindGameObjectWithTag("stena_tren");
        stena.GetComponent<Ladder>().enabled = false;
        man.GetComponent<FirstPersonController>().enabled = false;

        for (int i = 0; i < instr.Length; i++)
        {
            instr[i].SetActive(false);
        }
    }
    public void Trenirovka()
    {
        Debug.Log("!!!!!!!!!!");
        GameObject man;
        man = GameObject.FindGameObjectWithTag("Player");
        trennirovka = true;
        Canvas_Polosa.SetActive(false);
        man.transform.position = Vector3.MoveTowards(man.transform.position, spawn.position, 100f);
        Cursor.lockState = CursorLockMode.Locked;
        GameObject stena;
        stena = GameObject.FindGameObjectWithTag("stena_tren");
        stena.GetComponent<Ladder>().enabled = true;

    }

    public void Start_polosa()
    { 
        start = true;
        Pravila.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Ochet.SetActive(true);
    }

    IEnumerator timer()
    {
        timerText.gameObject.SetActive(true);
        koef = 0;
        while (true)
        {

            if (Finish_polosa_zachet.enter == true)
                yield break;

            if (sec == 59)
            {
                min++;
                sec = -1;
            }

            if (sec >= 15 || min > 0)
            {
                score += -35;
            }
            sec++;
            timerText.text = min.ToString("D2") + ":" + sec.ToString("D2");
            yield return new WaitForSeconds(1);
            if(score < 0)
            {
                score = 0;
            }
        }
        
    }
}