using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimongTrigg : MonoBehaviour
{
    bool enter;
    int kurator = 0;
    int fps_shet = 0;
    public GameObject Podskazka;
    public GameObject Obj;
    public GameObject Ob;
    public GameObject zvuk;
    public GameObject komanda;
    public GameObject GG;
    public GameObject GG_2;
    public GameObject Camera;
  //  public GameObject Telefon_trubka;
    public Animator myAnymator;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Fire;
    public GameObject BOOOM_1;
    public GameObject BOOOM_2;
    public GameObject BOOOM_3;
    public GameObject BOOOM_4;
    public GameObject fIRE_VOLIUM;
    public GameObject Doklad;

    private void Start()
    {
   
        Text1.SetActive(true);
    }
    void Update() {

        
        if (enter == true && Input.GetKeyDown(KeyCode.E) && kurator == 0 && GG.activeSelf)
        {
            fps_shet = 1;
            Podskazka.SetActive(false);
            GG.SetActive(false);
            Camera.SetActive(true);

            //;
        }
        if (enter == true && Input.GetKeyDown(KeyCode.E) && kurator == 0 && GG_2.activeSelf)
        {
            fps_shet = 2;
            Podskazka.SetActive(false);
            GG_2.SetActive(false);
            Camera.SetActive(true);

            //;
        }
        if (Camera.activeSelf)
        {
            BiG_Quest.tmp++;
            if (Input.GetKeyDown(KeyCode.Q))
            {
                StartCoroutine(Audio());
                Text1.SetActive(false);
                Text2.SetActive(true);
                myAnymator.Play("Telefon");
                myAnymator.SetFloat("berem", 1);
                kurator++;

            }
            if (Input.GetKeyDown(KeyCode.E) && kurator == 1)
            {
                Doklad.SetActive(false);
                Text2.SetActive(false);
                myAnymator.Play("Telefon");
                myAnymator.SetFloat("berem", -1);
                kurator++;
                StartCoroutine(Komanda());
            }
        }

    }
	     

   public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" ){
       	enter = true;
            if(kurator == 0)
	    Podskazka.SetActive(true);
        }   
   }
    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = false;
            Podskazka.SetActive(false);
        }
    }
IEnumerator Komanda(){
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
        komanda.SetActive(true);
	yield return new WaitForSeconds(5.1f);
	Obj.GetComponent<Animator>().enabled = true;
  	Ob.GetComponent<Animator>().enabled = true;
	zvuk.SetActive(true);
        yield return new WaitForSeconds(2f);
        BOOOM_1.SetActive(true);

        BOOOM_3.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(0.01f);
        BOOOM_3.GetComponent<MeshRenderer>().enabled = true;

        yield return new WaitForSeconds(0.5f);
        BOOOM_2.SetActive(true);
        BOOOM_4.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(0.01f);
        BOOOM_4.GetComponent<MeshRenderer>().enabled = true;

        Fire.SetActive(true);
        yield return new WaitForSeconds(4f);
        BOOOM_3.SetActive(false);
        BOOOM_4.SetActive(false);
       
        fIRE_VOLIUM.SetActive(true);
        
    }
    IEnumerator Audio()
    {
        yield return new WaitForSeconds(1.0f);
        Doklad.SetActive(true);
    }
}
