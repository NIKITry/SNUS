using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneBlack : MonoBehaviour
{
    public FirstPersonController FPS;
    public GameObject Object,AlphaObj;
    Image AlphaImage;
    public float AlphaA;
    bool PressStart;
    // Start is called before the first frame update
    void Start()
    {
        AlphaImage = AlphaObj.GetComponent<Image>();
        AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a );
    }

    // Update is called once per frame
    void Update()
    {
        if (PressStart && AlphaImage.color.a > 0)
        {
            AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a - 0.5f * Time.deltaTime);
            AlphaA = AlphaImage.color.a;
           // Debug.Log(AlphaA);
            if (AlphaImage.color.a < 0.1)
            {
                Object.SetActive(true);
                FPS.setFreeze(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        

        }
    }

    public void Press()
    {
        Time.timeScale = 1f;
        GameObject script;
        script = GameObject.Find("MainCanvas");
        script.GetComponent<Cursor_StarMain>().enabled = false;
        FPS.setFreeze(false);
        PressStart = true;
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().enabled = true;
        
    }

}
