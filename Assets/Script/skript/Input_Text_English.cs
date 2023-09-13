using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Text_English : MonoBehaviour
{
    public GameObject Fps_1, Fps_2;
    public GameObject LordCanvas;
    public InputField GameNametext;
    public Text score;
    public Text lvl;
    public int scr;
    public GameObject GameContentPanel, Camera_Morze;


    public AudioSource MySourse;


    public AudioClip[] Audio_mesh;
    public int i = 0;

    public void Start()
    {

        score.text = "Score = " + scr;
        lvl.text = "Lvl: " + (i + 1);
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

    }

    public void Closebttn()
    {
        if (GameNametext.text == "sos" && i == 0)           //1
        {
            scr += 5;
            score.text = "Score = " + scr;
            i++;
            lvl.text = "Lvl: " + (i);
            health.xp += 5;

        }

        if (GameNametext.text == "knife" && i == 1)  //2
        {
            scr += 8;
            score.text = "Score = " + scr;
            i++;
            health.xp += 8;

            //  lvl.text = "Уровень: " + i + 1;
        }
        if (GameNametext.text == "rear" && i == 2)  //3
        {
            scr += 8;
            score.text = "Score = " + scr;
            i++;
            lvl.text = "Lvl: " + i;
            health.xp += 8;
        }
        if (GameNametext.text == "regiment" && i == 3)  //4
        {
            scr += 12;
            score.text = "Score = " + scr;
            i++;
            // lvl.text = "Уровень: " + i + 1;
            health.xp += 12;
        }
        if (GameNametext.text == "ak74" && i == 4)  //5
        {
            scr += 12;
            score.text = "Score = " + scr;
            i++;
            lvl.text = "Lvl: " + i;
            health.xp += 12;
        }

        if (GameNametext.text == "binoculars" && i == 5)  //6
        {
            scr += 15;
            score.text = "Score = " + scr;
            i++;
            //  lvl.text = "Уровень: " + i + 1;
            health.xp += 15;
        }
        if (GameNametext.text == "battalion" && i == 6)  //7
        {
            scr += 15;
            score.text = "Score = " + scr;
            i++;
            lvl.text = "Lvl: " + i;
            health.xp += 15;
        }
        if (GameNametext.text == "communication" && i == 7) //8
        {
            scr += 25;
            score.text = "Score = " + scr;
            i++;
            lvl.text = "Lvl: " + i;
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
        if (F.flag_weapon != true)
            Fps_1.SetActive(true);

        else
            Fps_2.SetActive(true);
        LordCanvas.SetActive(true);
    }
}
