using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class razvertca_time : MonoBehaviour
{
    public Text timerText;

    public static float min_;
    public static float sec_;
    public float mili_sec = 0;

    public finish_gonka finish;

    private void Start()
    {
        min_ = startTimer.min_5;
        sec_ = startTimer.sec_5;
        mili_sec = 0;
    }

    private void FixedUpdate()
    {
        if (finish.finish == true)
        {
            timerText.color = Color.green;
            return;
        }

        if (TP.tp_razvertca == true)
        {
            mili_sec += 0.02f;
            if (mili_sec >= 1)
            {
                sec_++;
                mili_sec = 0;
            }
            if (sec_ == 60)
            {
                min_++;
                sec_ = 0;
            }
        }
        timerText.text = string.Format("Минуты: " + min_ + "  " + "Секунды: " + sec_);// + "" + mili_sec;
    }
}
