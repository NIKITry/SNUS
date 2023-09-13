using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportNextScene : MonoBehaviour
{
    public bool[] QuestCheck;
    public int k = 0;
    bool enter;
    public GameObject TeleporMarker, Image;

    void Start()
    {
         enter = false;
        for (int i = 0; i < QuestCheck.Length; i++)
        {
            QuestCheck[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < QuestCheck.Length; i++)
        {
            if(QuestCheck[i] == true)
            {
                k++;
            }

            if(i == QuestCheck.Length - 1 && k != QuestCheck.Length)
            {
                k = 0;
            }

            else if (i == QuestCheck.Length - 1 && k == QuestCheck.Length && !enter)
            {
                Debug.Log("TeleportSpawn");
                StartCoroutine(Teleport());
            }
        }
    }

    IEnumerator Teleport()
    {

        enter = true;

        yield return new WaitForSeconds(3f);
            TeleporMarker.SetActive(true);
            GameObject man;
            man = GameObject.FindGameObjectWithTag("Player");
            man.GetComponent<FirstPersonController>().enabled = false;
            Image.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            
        
    }

    public void Click()
    {
        GameObject man;
        man = GameObject.FindGameObjectWithTag("Player");
        man.GetComponent<FirstPersonController>().enabled = true;
        Image.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
      
    }
}
