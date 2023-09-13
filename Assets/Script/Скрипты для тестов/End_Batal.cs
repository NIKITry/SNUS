using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End_Batal : MonoBehaviour
{
    
    public GameObject Podsk_na_exit;
    public GameObject loadCanv;
    public GameObject LordCanvas;
    public GameObject LoadSlider;
    public Slider slider;
    bool enter;
    // Start is called before the first frame update
    void Start()
    {
        Podsk_na_exit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enter == true && Input.GetKeyDown(KeyCode.H))
        {
            //SceneManager.LoadScene("snus");
            loadCanv.SetActive(true);
            LordCanvas.SetActive(false);
            StartCoroutine(Load());
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = true;
            Podsk_na_exit.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = false;
            Podsk_na_exit.SetActive(false);
        }
    }

    IEnumerator Load() // Прогрузка 
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("snus");
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
