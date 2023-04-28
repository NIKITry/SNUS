using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponRezult : MonoBehaviour
{
    public GameObject rezult, rezult_text, rezult_text_finish, barer;
    public Text six, seven, eight, nine, ten, sum;
    public GreenTarget GreenTarget;
    bool enter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enter && Input.GetKeyDown(KeyCode.E))
        {
            GameObject man;
            man = GameObject.FindGameObjectWithTag("Player");
            man.GetComponent<FirstPersonController>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            six.text = "��������� � '6': " + GreenTarget.six;
            seven.text = "��������� � '7': " + GreenTarget.sev;
            eight.text = "��������� � '8': " + GreenTarget.vos;
            nine.text = "��������� � '9': " + GreenTarget.nine;
            ten.text = "��������� � '10': " + GreenTarget.ten;
            sum.text = GreenTarget.scores + " �����";

            Weapon_trigg.ammo_bool = false;
            rezult.SetActive(true);
            rezult_text.SetActive(false);
            rezult_text_finish.SetActive(false);
            
        }
    }

    public  void OnClick()
    {
        rezult.SetActive(false);
        GameObject man;
        man = GameObject.FindGameObjectWithTag("Player");
        man.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        barer.SetActive(false);
        Achievements achievement = FindObjectOfType<Achievements>();
        achievement.showAchieve("Пройти \n стрелковый \n полигон", 4);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") { enter = true; rezult_text_finish.SetActive(true); }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") { enter = false; rezult_text_finish.SetActive(false); }
    }
}
