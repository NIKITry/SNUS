using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish_gonka : MonoBehaviour
{
    bool enter = false;

    public GameObject resalt;
    public Text score_result_text;
    public Text minText;
    public Text secText;
    public GameObject kamaz;

    public Text shtrafText;
    int shtraf_scr = 0;

    public bool finish = false;

    public static bool gonka_finish = false;

    public static int score_resalt = 0;

    public int score = 200; // баллы за проезд
    public Text scoreText;

    private void Start()
    {
        score_resalt = 0;
        finish = false;
        score = 200;
    }

    private void Update()
    {
        //score += TargetScript.score;

        scoreText.text = string.Format("Очки {0}", score + TargetScript.score);


        if (enter == true)
        {
            score_resalt = (int)((score + TargetScript.score) - (razvertca_time.min_ * 60 + razvertca_time.sec_) / 2);
            shtraf_scr = (int)((razvertca_time.min_ * 60 + razvertca_time.sec_) / 2);

            resalt.SetActive(true);
            score_result_text.text = string.Format("Очки {0}", score_resalt);
            minText.text = string.Format("Минуты: {0}", razvertca_time.min_);
            secText.text = string.Format("Секунды: {0}", razvertca_time.sec_);
            shtrafText.text = string.Format("Штраф: {0}", shtraf_scr);
            kamaz.GetComponent<CarControler>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            finish = true;
            gonka_finish = true;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "kuzov")
        {
            enter = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "kuzov")
        {
            enter = false;
        }
    }
}
