using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthBatal_Final : MonoBehaviour
{
    public GameObject trigg;
    public static int proideno;
    public int shetchik;
    public int pravilno;
    public int Vibor_testa;
    public static bool Global_enter;
    public GameObject Trigg_end;
    public GameObject Test;
    public GameObject Testing;
    public Text Text_zvanie;
    public Text Text_ball;



    private void Start()
    {
        Test.SetActive(false);
        Global_enter = false;
        Trigg_end.SetActive(false);
        
    }
    private void Update()
    {
        if (Testing.activeSelf)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if(health.lvl == 6 && GreenTarget.flag == true)
        {
            Test.SetActive(true);
        }
        if (health.lvl == 5 && GreenTarget.flag == false)
        {
            Test.SetActive(true);
        }

        if (Trigg_end.activeSelf)
        {
          
        }
    }
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





    public void Reshenie()
    {
        if (lenguage.len == 0)
        {
            Text_ball.text = "Правельных ответов " + pravilno + "/7";
            if (pravilno == 7)
            {
                health.xp += 100;
                health.lvl++;

                if (health.lvl == 7)
                    Text_zvanie.text = "Ваше звание: cтарший прапорщик";
                if (health.lvl == 8)
                    Text_zvanie.text = "Ваше звание: младший лейтенант";
            }
            if (health.lvl == 6)
                Text_zvanie.text = "Ваше звание: прапорщик";
        }

        else
        {
            Text_ball.text = "Correct responses " + pravilno + "/7";
            if (pravilno == 7)
            {
                health.xp += 100;
                health.lvl++;

                if (health.lvl == 7)
                    Text_zvanie.text = "Your rank: Warrant Officer class 1";
                if (health.lvl == 8)
                    Text_zvanie.text = "Your rank: 2nd Lieutenant";
            }
            if (health.lvl == 6)
                Text_zvanie.text = "Your rank:  Warrant Officer class 2";
        }
    

        //Text_ball.text = string.Format("Правельных ответов: {0}" + pravilno + " из 7");
        Destroy(trigg);
       // shetchik = 0;
      //  pravilno = 0;
        Global_enter = true;

        Trigg_end.SetActive(true);

    }

    public void Titri()
    {
        SceneManager.LoadScene("Titri");
    }

    
}
