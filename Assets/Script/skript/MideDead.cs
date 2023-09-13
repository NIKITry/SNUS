using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MideDead : MonoBehaviour
{
    public GameObject AlphaObj;
    public Image AlphaImage;
    public int AlphaA;
    public GameObject Audio_dead , LordCanvas;
    int  k = 0;

    public void Start()
    {
     
        AlphaImage = AlphaObj.GetComponent<Image>();
        AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a * 0);
       
    }
    private void FixedUpdate()
    {
        if(MinesPlaneTriggers.DeaDMan == true)
        {
            StartCoroutine(Komanda());

            if (Input.GetKeyDown(KeyCode.Space) && k == 1)
            {
                Debug.Log("!!");
                if (lenguage.len == 0)
                    SceneManager.LoadScene("батальон");

                if (lenguage.len == 1)
                    SceneManager.LoadScene("batalion");
            }
        }
        IEnumerator Komanda()
        {
            LordCanvas.SetActive(false);

            if (AlphaA == 0)
            {
                AlphaImage = AlphaObj.GetComponent<Image>();
                AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a + 0.5f * Time.deltaTime);
            }
            Audio_dead.SetActive(true);
          

            yield return new WaitForSeconds(3f);

            health.xp = 0;
            health.min_xp = 0;
            health.lvl = 1;
            healthBatal1_Radio.k1 = 0;
            healthBatal1_Radio.k2 = 0;
            healthBatal1_Radio.k3 = 0;
            healthBatal1_Radio.k4 = 0;
            healthBatal1_Radio.k5 = 0;
            healthBatal1_Radio.k6 = 0;
            healthBatal1_Radio.proideno = 0;
            k = 1;

        }

    }
    
}
