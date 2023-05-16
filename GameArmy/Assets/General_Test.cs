using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class General_Test : MonoBehaviour
{
    public GameObject[] ButtonTest, RangHerou;
    public Text lvl, expoint;
    GameObject SelectButton;
    int good, exp, level = 1;

    public AudioClip din;
    AudioSource AudioCameraFly;

    public void Start()
    {
        AudioCameraFly = GameObject.FindGameObjectWithTag("CameraFly").gameObject.GetComponent<AudioSource>();
    }
    public void PutOn(GameObject button)
    {
         for (int i = 0; i < ButtonTest.Length; i++)
        {
            
            if (button == ButtonTest[i] && button.tag == "TestButton")
            {
                SelectButton = button;
                //Debug.Log(SelectButton.transform.parent);
            }
            
        }
    } 

    public void Good()
    {
        good++;
        Debug.Log(good);
    }

    public void Final()
    {
        if(good == 5)
        {
            AudioCameraFly.PlayOneShot(din);
            SelectButton.transform.tag = "Untagged";
            SelectButton.transform.GetChild(0).gameObject.GetComponent<Text>().color = Color.green;
            SelectButton.GetComponent<Button>().enabled = false;

            exp += 120;
            expoint.text = "Умение " + exp;

            RangHerou[level - 1].SetActive(false);
            RangHerou[level].SetActive(true);

            level++;
            lvl.text = "Уровень " + level;

        }
        good = 0;
    }

    

}
