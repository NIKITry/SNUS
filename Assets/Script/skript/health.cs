using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class health : MonoBehaviour
{
    public static int xp;
    
    public int kol=0;
    public static int lvl=1;
    public static int max_xp = 100;
    public static int min_xp = 0;
    public Slider slider;
    public Text txt_NAME;
    public Text txt_FENAME;
    public Text txt_xp;
    public Text txt_lvl;
    public int proverka = 0;
    public int reshenie = 0;
    //public Image art;
    public int rashet = 6;
    public GameObject Zanovo;
    public GameObject Butten;
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject img6;
    public GameObject img7;
    public GameObject canvas;
    public GameObject canvas2;
    public GameObject Р_419Л1;
    public GameObject Р_441_ОВ;
    public GameObject P_260T;
    public GameObject ЭД_2X30;

    public void Test1()
    {
        reshenie = 1;
    }
    public void Test2()
    {
        reshenie = 2;
    }
    public void Test3()
    {
        reshenie = 3;
    }
    public void Test4()
    {
        reshenie = 4;
    }
    public void Reshenie()
    {
       
        if (reshenie == 1 && proverka == 5)
        {
            rashet = 5;
            
            
                proverka = 0;
                reshenie = 0;
                kol = 0;
                Destroy(Р_419Л1);
            
         }

        if (reshenie == 2 && proverka == 5)
        {
           
                rashet = 5;
            
                proverka = 0;
                reshenie = 0;
                kol = 0;
                Destroy(Р_441_ОВ);
            
            
        }

        if (reshenie == 3 && proverka == 5)
        {

            rashet = 5;
            
            
                proverka = 0;
                reshenie = 0;
                kol = 0;
                Destroy(P_260T);
            
        }
        if (reshenie == 4 && proverka == 5)
        {
            rashet = 5;
           
            
                proverka = 0;
                reshenie = 0;
                kol = 0;
                Destroy(ЭД_2X30);
            
        }
        else if ( proverka >= 0 && proverka < 5)
        {
            rashet = proverka;
            proverka = 0;
            kol = 0;
        }
    }
    public void shcet() {
        kol += 1;
    } 
    public void BigBall()
    {
        //kol++;
     //  proverka++;
    }
    public void OnClick()
    {
        proverka++;
        if (proverka == 5)
            {
            xp += 50;
            min_xp += 50;
            
            }
      
        if (max_xp - min_xp <= 0)
        {
            lvl += 1;
            max_xp += 100;
           // xp = 0;
            
                img1.SetActive(true);
        }
       
    }

 

  
    void Update()
    {
        if (lvl == 2)
        {
            img1.SetActive(false);
            img2.SetActive(true);
        }
        if (lvl == 3)
        {
            img2.SetActive(false);
            img3.SetActive(true);
        }
        if (lvl == 4)
        {
            img3.SetActive(false);
            img4.SetActive(true);
        }
        if (lvl == 5)
        {
            img4.SetActive(false);
            img5.SetActive(true);
        }
        if (lvl == 6)
        {
            img5.SetActive(false);
            img6.SetActive(true);
        }
        if (lvl == 7)
        {
            img6.SetActive(false);
            img7.SetActive(true);
        }
        if (lvl != 1)
        {
            img1.SetActive(false);
        }
        slider.value = xp;
        txt_NAME.text = FIO.a;
        txt_FENAME.text = FIO.b;
        txt_xp.text = "Опыт: " + xp;
        txt_lvl.text = "Уровень: " + lvl;
    }
}
