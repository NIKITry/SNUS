using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [Space]
    [Header("START MENU BUTTON")]
    [SerializeField] GameObject playBt;
    [SerializeField] GameObject settingsBt;
    [SerializeField] GameObject exitBt;
    [Space]
    [SerializeField] GameObject backBt;


    [Space]
    [Header("STAGE BUTTON")]
    [Space]
    [SerializeField] GameObject level_List;
    [Space]
    [SerializeField] GameObject first_Lvl_Bt;
    [SerializeField] GameObject second_Lvl_Bt;
    [SerializeField] GameObject third_Lvl_Bt;
    [SerializeField] GameObject forth_Lvl_Bt;
    [SerializeField] GameObject forth_Lvl_Bt_Night;
    [SerializeField] GameObject forth_Lvl_Bt_Day;
    [SerializeField] GameObject fifth_Lvl_Bt;

    [Space]
    [Header("INFORMATION")]
    [Space]
    [SerializeField] GameObject lvl_Info;
    [Space]
    [SerializeField] GameObject first_Lvl_Text_Inf;
    [SerializeField] GameObject second_Lvl_Text_Inf;
    [SerializeField] GameObject third_Lvl_Text_Inf;
    [SerializeField] GameObject forth_Lvl_Text_Inf;
    [SerializeField] GameObject fifth_Lvl_Text_Inf;

    [Space]
    [Header("LOAD")]
    [Space]
    [SerializeField] GameObject menu_Canvas;
    [Space]
    [SerializeField] GameObject load_Canvas;
    [SerializeField] Slider load_Slider;

    [Space]
    [SerializeField] GameObject instructionButton;
    [Space]
    [SerializeField] GameObject resaltBt;

    /*
    [Space]
    [Header("START BUTTON")]
    [Space]
    [SerializeField] GameObject start_First_Lvl_Bt;
    */



    public void PlayBt()
    {
        level_List.SetActive(true);
        playBt.SetActive(false);
        settingsBt.SetActive(false);
        exitBt.SetActive(false);
        backBt.SetActive(true);

        instructionButton.SetActive(false);

        resaltBt.SetActive(false);
    }

    public void SettingsBt()
    {

    }

    public void ExitBt()
    {
        Application.Quit();
    }

    public void BackBt()
    {
        level_List.SetActive(false);
        playBt.SetActive(true);
        settingsBt.SetActive(true);
        exitBt.SetActive(true);
        backBt.SetActive(false);

        instructionButton.SetActive(true);

        resaltBt.SetActive(true);
    }




    // select the level & mack info
    public void First_Lvl_Bt()
    {
        backBt.SetActive(false);
        level_List.SetActive(false);
        lvl_Info.SetActive(true);
        first_Lvl_Text_Inf.SetActive(true);

        second_Lvl_Text_Inf.SetActive(false);
        third_Lvl_Text_Inf.SetActive(false);
        forth_Lvl_Text_Inf.SetActive(false);
        fifth_Lvl_Text_Inf.SetActive(false);
    }

    public void Second_Lvl_Bt()
    {
        backBt.SetActive(false);
        level_List.SetActive(false);
        lvl_Info.SetActive(true);
        second_Lvl_Text_Inf.SetActive(true);

        first_Lvl_Text_Inf.SetActive(false);
        third_Lvl_Text_Inf.SetActive(false);
        forth_Lvl_Text_Inf.SetActive(false);
        fifth_Lvl_Text_Inf.SetActive(false);
    }

    public void Third_Lvl_Bt()
    {
        backBt.SetActive(false);
        level_List.SetActive(false);
        lvl_Info.SetActive(true);
        third_Lvl_Text_Inf.SetActive(true);

        first_Lvl_Text_Inf.SetActive(false);
        second_Lvl_Text_Inf.SetActive(false);
        forth_Lvl_Text_Inf.SetActive(false);
        fifth_Lvl_Text_Inf.SetActive(false);
    }

    public void Forth_Lvl_Bt()
    {
        backBt.SetActive(false);
        level_List.SetActive(false);
        lvl_Info.SetActive(true);
        forth_Lvl_Text_Inf.SetActive(true);

        first_Lvl_Text_Inf.SetActive(false);
        second_Lvl_Text_Inf.SetActive(false);
        third_Lvl_Text_Inf.SetActive(false);
        fifth_Lvl_Text_Inf.SetActive(false);
    }

    public void Fifth_Lvl_Bt()
    {
        backBt.SetActive(false);
        level_List.SetActive(false);
        lvl_Info.SetActive(true);
        fifth_Lvl_Text_Inf.SetActive(true);

        first_Lvl_Text_Inf.SetActive(false);
        second_Lvl_Text_Inf.SetActive(false);
        third_Lvl_Text_Inf.SetActive(false);
        forth_Lvl_Text_Inf.SetActive(false);
    }


    public void Back_In_Start_Menu_Bt()
    {
        playBt.SetActive(true);
        settingsBt.SetActive(true);
        exitBt.SetActive(true);
        lvl_Info.SetActive(false);

        first_Lvl_Text_Inf.SetActive(false);
        second_Lvl_Text_Inf.SetActive(false);
        third_Lvl_Text_Inf.SetActive(false);
        forth_Lvl_Text_Inf.SetActive(false);
        fifth_Lvl_Text_Inf.SetActive(false);

        instructionButton.SetActive(true);
    }

    public void Back_In_Lvl_List_Bt()
    {
        level_List.SetActive(true);
        lvl_Info.SetActive(false);

        first_Lvl_Text_Inf.SetActive(false);
        second_Lvl_Text_Inf.SetActive(false);
        third_Lvl_Text_Inf.SetActive(false);
        forth_Lvl_Text_Inf.SetActive(false);
        fifth_Lvl_Text_Inf.SetActive(false);
    }




    // start lvl
    public void Start_First_Lvl_Bt()
    {
        menu_Canvas.SetActive(false);
        load_Canvas.SetActive(true);
        StartCoroutine(Load("First_Lvl"));
    }

    public void Start_Second_Lvl_Bt()
    {
        menu_Canvas.SetActive(false);
        load_Canvas.SetActive(true);
        StartCoroutine(Load("Second_Lvl"));
    }

    public void Start_Third_Lvl_Bt()
    {
        menu_Canvas.SetActive(false);
        load_Canvas.SetActive(true);
        StartCoroutine(Load("it-scen"));
    }

    public void Start_Forth_Lvl_Bt()
    {
        menu_Canvas.SetActive(false);
        load_Canvas.SetActive(true);
        StartCoroutine(Load("Forth_Lvl"));
    }

    public void Start_Fifth_Lvl_Bt()
    {
        menu_Canvas.SetActive(false);
        load_Canvas.SetActive(true);
        StartCoroutine(Load("individ runing"));
    }

    IEnumerator Load(string str) // Прогрузка
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(str);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            load_Slider.value = progress;
            yield return null;
        }
    }
}
