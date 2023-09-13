using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class load : MonoBehaviour
{
    public GameObject menuCanv;
    public GameObject loadCanv;

    public GameObject LoadSlider;
    public Slider slider;
    public string str;

    //public GameObject dropDown;
    //private lenguage len;
    public lenguage len;
    // Start is called before the first frame update 
    public void LoadScence(int level)
    {
        if(lenguage.len == 0 || lenguage.len == 1)
        {
            menuCanv.SetActive(false);
            loadCanv.SetActive(true);
            str = "snus";
            StartCoroutine(Load(str));
            //SceneManager.LoadScene("snus");
        }
        /*  else if(lenguage.len == 1)
         {
             menuCanv.SetActive(false);
             loadCanv.SetActive(true);
             str = "batalion";
             StartCoroutine(Load(str));
             //SceneManager.LoadScene("snusangl");
         }

         if(dropDown.GetComponent<lenguage>().len == 1)
         {
             SceneManager.LoadScene("snus");
         }
         else if (dropDown.GetComponent<lenguage>().len == 2)
         {
             SceneManager.LoadScene("snusangl");
         }
         */
        //SceneManager.LoadScene(level);
    }

    IEnumerator Load(string str) // Прогрузка 
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(str);
        LoadSlider.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }

    // Update is called once per frame 
    public void Exit()
    {
        Application.Quit();
    }
}