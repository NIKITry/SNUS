using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gas_mask : MonoBehaviour
{
    public GameObject GasMask;

    //public GameObject Blacke_plane;
    public Odejda_dly_geroy Odejda_Dly_Geroy;
    public GameObject AlphaObj;
    public Image AlphaImage;
    public int AlphaA;
    public bool blake;
    public AudioSource _audio;
    public AudioSource _audio_1;
    public AudioClip Vdoh, dihanie, nadevanie;
    bool enter = true;
    int n = 0;
   public static int nadevaem = 0;
    void Start()
    {

        AlphaImage = AlphaObj.GetComponent<Image>();
        AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a * 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Odejda_dly_geroy.n == Odejda_Dly_Geroy.odejda.Length)
        {
            if (blake == true)
            {
                // AlphaImage = AlphaObj.GetComponent<Image>();
                AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a + 1.5f * Time.deltaTime);
                StartCoroutine(Zvuk());
            }

            if (Input.GetKeyDown(KeyCode.U) && enter == true && !GasMask.activeSelf)
            {
                blake = true;
                n = 1;
                nadevaem = 1;
                _audio.PlayOneShot(Vdoh);
                _audio.PlayOneShot(nadevanie);
                _audio.PlayOneShot(dihanie);

                _audio_1.PlayOneShot(Vdoh);
                _audio_1.PlayOneShot(nadevanie);
                _audio_1.PlayOneShot(dihanie);
            }

            else if (Input.GetKeyDown(KeyCode.U) && enter == false && GasMask.activeSelf)
            {
                blake = true;
                n = 2;

            }
        }
    }
  

   IEnumerator Zvuk()
    {
        
       
        yield return new WaitForSeconds(1.5f);
        blake = false;
        //AlphaImage = AlphaObj.GetComponent<Image>();
        AlphaImage.color = new Color(AlphaImage.color.r, AlphaImage.color.g, AlphaImage.color.b, AlphaImage.color.a * 0);
        if(enter == true && !GasMask.activeSelf && n == 1)
        {
            GasMask.SetActive(true);
           
            yield return new WaitForSeconds(1.5f);
            enter = false;
            n = 0;
            yield  break;

        }
     else if (enter == false && GasMask.activeSelf && n == 2)
        {
            GasMask.SetActive(false);
            nadevaem = 0;
            yield return new WaitForSeconds(1f);
            enter = true;
            
            n = 0;
            yield break;

        }
    }
}
