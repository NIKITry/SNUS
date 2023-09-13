using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Bomba : MonoBehaviour
{
    int k = 0;
    
    public GameObject Plane;
    public GameObject DEAD;
    public GameObject Zvuk_plane;
    public GameObject AlphaObj;
    public Image AlphaImage;
    public int AlphaA;
    public GameObject LordCanvas;
   
    // Start is called before the first frame update
    public GameObject bomba;
   public static int kinematik_flag = 0;
    [System.Obsolete]
    public void Start()
    {
        Plane.transform.position = bomba.transform.position;
        k = 0;
        AlphaImage = AlphaObj.GetComponent<Image>();
         AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a * 0);
        kinematik_flag = 0;
    }

    [System.Obsolete]
    void Update()
    {
        StartCoroutine(Komanda());
        if (Input.GetKeyDown(KeyCode.Space) && k == 1)
        {
            Debug.Log("!!");
            if (lenguage.len == 0)
                SceneManager.LoadScene("батальон");

            if (lenguage.len == 1)
                SceneManager.LoadScene("batalion");
        }
    }

    // Update is called once per frame




    [System.Obsolete]
    IEnumerator Komanda()
    {
        
        yield return new WaitForSeconds(40.0f);
        kinematik_flag = 1;
        bomba.GetComponent<Plane>().enabled = false;
        bomba.GetComponent<Animator>().enabled = true;
        bomba.GetComponent<Rigidbody>().isKinematic = false;
        yield return new WaitForSeconds(4.1f);
        LordCanvas.SetActive(false);
        Zvuk_plane.SetActive(false);
        DEAD.SetActive(true);
    
        if (AlphaA == 0)
        {
           AlphaImage = AlphaObj.GetComponent<Image>();
            AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a + 0.5f * Time.deltaTime);
        }
       
        yield return new WaitForSeconds(3f);
      
        health.xp = 0;
        health.min_xp = 0;
        health.lvl = 1;
        healthBatal1_Radio.k1 = 0;
        healthBatal1_Radio.k2 = 0;
        healthBatal1_Radio.k3 = 0;
        healthBatal1_Radio.k4 = 0;
        healthBatal1_Radio.k5 = 0;
        healthBatal1_Radio.k6 = 0;
        healthBatal1_Radio.proideno = 0;
        k = 1;

    }
}
