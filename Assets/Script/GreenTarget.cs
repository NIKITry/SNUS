using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenTarget : MonoBehaviour
{
    public static int scores = 0;
    public int scr = 0;
  
    public static int oldscore = 0;
    public List<int> scoresList;

    public Transform center;
    public Transform edge;

    public Text scoresText;
    public Text scoresText_eng;

    int k = 0;
    public static bool flag;
    private float totalLength;
    private float sectionLength;
    public  int six;
    public  int sev;
    public  int vos;
    public  int nine;
    public  int ten;
    public Text SIX, SIX_eng;
    public Text SEV, SEV_eng;
    public Text VOS, VOS_eng;
    public Text NINE, NINE_eng;
    public Text TEN, TEN_eng;
    public Text Obshi, Obshi_eng;

    private void Start()
    {
        k = 0;
        totalLength = (edge.position - center.position).magnitude;
        sectionLength = totalLength / scoresList.Count;
        six = 0;
        sev = 0;
        vos = 0;
        nine = 0;
        ten = 0;
        scr = 0;
        scoresText.text = string.Format("Очки: {0}", scr);
    }

    public void Update()
    {
        if(k == 0 && scores >= 480)
        {
             Debug.Log("!!!!");
            //health.xp += 100;
           // health.min_xp += 100;
            flag = true;
            k = 1;
        }


    }
    public void CalculateScores(Vector3 hitPosition)
    {
        var dist = (hitPosition - center.position).magnitude;

        if (dist < totalLength)
        {
            scores += scoresList[(int)(dist / sectionLength)];
            
        }
            scr = scores;
            scoresText.text = string.Format("Очки: {0}", scores);

        if (scores - oldscore == 6)
            {
                six++;
                oldscore = scores;
            }
            if (scores - oldscore == 7)
            {
                sev++;
                oldscore = scores;
        }
            if (scores - oldscore == 8)
            {
                vos++;
            oldscore = scores;
        }
            if (scores - oldscore == 9)
            {
                nine++;
            oldscore = scores;
        }
            if (scores - oldscore == 10)
            {
                ten++;
            oldscore = scores;
        }
        
        Debug.Log("!!!");



        // if (lenguage.len == 1)

       /* if (lenguage.len == 0)
        {
            scoresText.text = string.Format("Очки: {0} / 600", scr);
            Obshi.text = string.Format("Очки: {0}", scr);
            SIX.text = string.Format("6x: {0}", six);
            SEV.text = string.Format("7x: {0}", sev);
            VOS.text = string.Format("8x: {0}", vos);
            NINE.text = string.Format("9x: {0}", nine);
            TEN.text = string.Format("10x: {0}", ten);
        }


        else if (lenguage.len == 1)
                scoresText_eng.text = string.Format("Scores: {0} / 600", scr);
                Obshi_eng.text = string.Format("Scores: {0}", scr);
        SIX_eng.text = string.Format("6x: {0}", six);
        SEV_eng.text = string.Format("7x: {0}", sev);
        VOS_eng.text = string.Format("8x: {0}", vos);
        NINE_eng.text = string.Format("9x: {0}", nine);
        TEN_eng.text = string.Format("10x: {0}", ten);
        */


    }
}
