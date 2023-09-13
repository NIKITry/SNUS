using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1 : MonoBehaviour
{
    public GameObject zadanie_poisk_predmetov_2;
    public GameObject task_1_col;
    public GameObject proverkaImage;
    public GameObject zadanie_proverkaImage;

    public GameObject binocl;

    bool flag = false;
    public bool task_1_start = false;

    bool klavisha;

    private void Start()
    {
        proverkaImage.SetActive(false);
        zadanie_proverkaImage.SetActive(false);
    }

    private void Update()
    {
        if (flag == true)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                task_1_start = true;
                zadanie_poisk_predmetov_2.GetComponent<SpriteRenderer>().enabled = false;
                task_1_col.GetComponent<BoxCollider>().enabled = false;
                proverkaImage.SetActive(true);
                flag = false;
            }            
        }

        if (task_1_start == true && Input.GetKeyDown(KeyCode.Tab))
        {
            klavisha = !klavisha;
            if (klavisha == true)
            {
                zadanie_proverkaImage.SetActive(true);
            }
            else
            {
                zadanie_proverkaImage.SetActive(false);
            } 
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            flag = true;
        }
    }
}
