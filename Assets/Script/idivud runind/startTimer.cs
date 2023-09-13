using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startTimer : MonoBehaviour
{
    public Text timerText;
    private bool enter = false;

    public static float min_5;
    public static float sec_5;
    public float mili_sec = 0;

    private void Start()
    {
        min_5 = 0;
        sec_5 = 0;
        mili_sec = 0;
    }

    private void FixedUpdate()
    {
        if (enter == true)
        {
            mili_sec += 0.02f;
            if (mili_sec >= 1)
            {
                sec_5++;
                mili_sec = 0;
            }
            if (sec_5 == 60)
            {
                min_5++;
                sec_5 = 0;
            }
            // timerText.text = min.ToString() + ":" + sec.ToString() + ":" + mili_sec.ToString("f2");
        }
        timerText.text = string.Format("Минуты: " + min_5 + "  " + "Секунды: " + sec_5);// + "" + mili_sec;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "kuzov")
        {
            enter = true;
            this.GetComponent<BoxCollider>().enabled = false;
        }
        Debug.Log(enter);
    }
}
