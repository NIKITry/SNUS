using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DamageHealth : MonoBehaviour
{
    public static int HP = 100;
    public GameObject _audiodead;
    public AudioClip shotSFX;
    public GameObject LordCnavas;
    public Text Health;
    public GameObject AlphaObj;
    public Image AlphaImage;
    public int AlphaA;
    public ProgressBar Pb;
    int HP_max;
    int k = 0;
    // Start is called before the first frame update

    private void Start()
    {
        
            _audiodead.SetActive(false);
        AlphaObj.SetActive(false);
        k = 0;
        HP = 100;
        HP_max = HP;
        AlphaImage = AlphaObj.GetComponent<Image>();
        AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a * 0);
    }
    void Update()
    {

        if (Pb.BarValue == 0)
        {
            DeadForever();
        }
      

       
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HP -= 10;
            Health.text = "Здоровье: " + HP;
            Debug.Log("!!!");
        }
    }
    public void DeadForever()
    {
        StartCoroutine(Revers());
        if (Input.GetKeyDown(KeyCode.Space) && k == 1)
        {
     

                SceneManager.LoadScene("батальон");


        }


    }

    IEnumerator Revers()
    {
        LordCnavas.SetActive(false);
        _audiodead.SetActive(true);
        if (AlphaA == 0)
        {
            AlphaObj.SetActive(true);
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
