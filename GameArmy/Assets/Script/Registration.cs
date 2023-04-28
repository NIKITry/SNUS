using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Registration : MonoBehaviour
{
    public GameObject Registr;
    public FirstPersonController FPS;
    bool enter;
    public Text text_name, text_fename;
    public Text text_name_reg, text_fename_reg;
    public GameObject Name, Fename;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (enter)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }  
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = true;
            FPS.setFreeze(true);
            Registr.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //  script.GetComponent<>();
        }
    }

    public void Continious()
    {
        text_name_reg.text = text_name.text;
        text_fename_reg.text = text_fename.text;
        Name.SetActive(true);
        Fename.SetActive(true);
        enter = false;
        Registr.SetActive(false);
        FPS.setFreeze(false);
        Cursor.lockState = CursorLockMode.Locked;
        Achievements achievement = FindObjectOfType<Achievements>();
        achievement.showAchieve("Зарегистрироваться", 0);
    } 
}
