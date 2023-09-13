using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOM_plane : MonoBehaviour
{
    public int fps_shet = 0;
    public GameObject Plane;
    public GameObject Arrow;
    public GameObject Trevoga;
    public GameObject E;
    public GameObject Q;
    public GameObject W;
    public GameObject Camera;
    public GameObject GG;
    public GameObject GG_2;
    public  bool enter;
    public static bool enter_out;
    public Animator myAnymator_1;
    public Animator myAnymator_2;
    public GameObject Audio_soobchenie;
    int kurator = 0;

    public void Start()
    {
        Trevoga.SetActive(false);
        Q.SetActive(false);
        E.SetActive(false);
        W.SetActive(false);
        Arrow.SetActive(false);
        enter_out = false;
        enter = false;
    }
    private void Update()
    {
        if (Plane.activeSelf)
        {
            if(kurator == 0)
            Trevoga.SetActive(true);
            Arrow.SetActive(true);

            if (enter == true && kurator == 0)
                E.SetActive(true);
            else
                E.SetActive(false);

            if (enter == true && Input.GetKeyDown(KeyCode.E) && kurator == 0 && GG.activeSelf)
            {
                fps_shet = 1;
                Trevoga.SetActive(false);
                Arrow.SetActive(false);
                E.SetActive(false);
                Camera.SetActive(true);
                GG.SetActive(false);
                kurator = 1;
            }

            if (enter == true && Input.GetKeyDown(KeyCode.E) && kurator == 0 && GG_2.activeSelf)
            {
                fps_shet = 2;
                Trevoga.SetActive(false);
                Arrow.SetActive(false);
                E.SetActive(false);
                Camera.SetActive(true);
                GG_2.SetActive(false);
                kurator = 1;
            }
            if (Camera.activeSelf)
            {
                if(kurator == 1)
                Q.SetActive(true);

                if (Input.GetKeyDown(KeyCode.Q) && kurator == 1)
                {
                    StartCoroutine(Audio());
                    Q.SetActive(false);
                    Debug.Log("1111");
                    myAnymator_1.Play("Provod");
                    myAnymator_1.SetFloat("Provod", 1);
                    myAnymator_2.Play("Rupor");
                    myAnymator_2.SetFloat("Rupor", 1);
                    kurator = 2;
                    W.SetActive(true);
                }
                if (Input.GetKeyDown(KeyCode.W) && kurator == 2)
                {
                    Audio_soobchenie.SetActive(false);
                    myAnymator_1.Play("Provod");
                    myAnymator_1.SetFloat("Provod", -1);
                    myAnymator_2.Play("Rupor");
                    myAnymator_2.SetFloat("Rupor", -1);
                    W.SetActive(false);
                    StartCoroutine(Komanda());

                }
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            enter = true;

    }
    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
            enter = false;

    }
    IEnumerator Komanda()
    {
        yield return new WaitForSeconds(2.0f);
        if (fps_shet == 1)
        {
            GG.SetActive(true);
        }
        else
        {
            GG_2.SetActive(true);
        }
        Camera.SetActive(false);
       
        yield return new WaitForSeconds(4.0f);
        enter_out = true;
    }
    IEnumerator Audio()
    {
        yield return new WaitForSeconds(1.0f);
        Audio_soobchenie.SetActive(true);
    }
}
