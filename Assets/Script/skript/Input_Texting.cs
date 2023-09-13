using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Texting : MonoBehaviour
{
    public GameObject Fps_1, Fps_2;
    public GameObject LordCanvas;
    public InputField GameNametext; 
    public Text score;
    public Text lvl;
    public int scr;
    public GameObject  GameContentPanel, Camera_Morze; 


    public AudioSource MySourse;
    

    public AudioClip[] Audio_mesh;
    int i = 0;
  
    public void Start()
    {
      
        score.text = "Oчки = " + scr;
        lvl.text = "Уровень: " + (i + 1);
    }
    private void Update()
    {
        if (GameNametext.text == "")
        {
            GameContentPanel.SetActive(false);
        }
        else
        {
            GameContentPanel.SetActive(true);
        }

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    public void Closebttn() 
    {
        if (GameNametext.text == "сос" && i == 0)           //1
        {
            scr += 5;
            score.text = "Oчки = " + scr;
            i++;
            lvl.text = "Уровень: " + (i);
            health.xp += 5;
            
        }

        if (GameNametext.text == "нож" && i == 1)  //2
        {
            scr += 8;
            score.text = "Oчки = " + scr;
            i++;
            lvl.text = "Уровень: " + (i);
            health.xp += 8;
            
            //  lvl.text = "Уровень: " + i + 1;
        }
        if (GameNametext.text == "тыл" && i == 2)  //3
        {
            scr += 8;
            score.text = "Oчки = " + scr;
            i++;
            lvl.text = "Уровень: " + i;
            health.xp += 8;
        }
        if (GameNametext.text == "полк" && i == 3)  //4
        {
            scr += 12;
            score.text = "Oчки = " + scr;
            i++;
            // lvl.text = "Уровень: " + i + 1;
            health.xp += 12;
        }
        if (GameNametext.text == "ак74" && i == 4)  //5
        {
            scr += 12;
            score.text = "Oчки = " + scr;
            i++;
            lvl.text = "Уровень: " + i;
            health.xp += 12;
        }

        if (GameNametext.text == "бинокль" && i == 5)  //6
        {
            scr += 15;
            score.text = "Oчки = " + scr;
            i++;
            //  lvl.text = "Уровень: " + i + 1;
            health.xp += 15;
        }
        if (GameNametext.text == "батальон" && i == 6)  //7
        {
            scr += 15;
            score.text = "Oчки = " + scr;
            i++;
            lvl.text = "Уровень: " + i;
            health.xp += 15;
        }
        if (GameNametext.text == "радиосвязь" && i == 7) //8
        {
            scr += 25;
            score.text = "Oчки = " + scr;
            i++;
            lvl.text = "Уровень: " + i;
            health.xp += 25;
            health.lvl += 1;
        }
        GameNametext.text = string.Empty;
    }

   public void ClickSound()
    {
        MySourse.PlayOneShot(Audio_mesh[i]);
    }
    public void Exit()
    {
        Camera_Morze.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if(F.flag_weapon != true)
            Fps_1.SetActive(true);

        else
            Fps_2.SetActive(true);
        LordCanvas.SetActive(true);
    }

}
