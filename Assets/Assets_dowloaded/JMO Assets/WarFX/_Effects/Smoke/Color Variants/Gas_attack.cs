using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas_attack : MonoBehaviour
{
    bool otrava;
    public ProgressBar Pb;
    public AudioSource _audio;
    public AudioClip kashel;

    public float fireRate = 1;
    public float nextFire = 0f;

    private void Start()
    {
       // _audio.PlayOneShot(boom);
    }
    // Update is called once per frame
    void Update()
    {
      /*  if (otrava == true && Time.time > nextFire && Gas_mask.nadevaem != 1)
        {
            nextFire = Time.time + 1f / fireRate;
            DamageHealth.HP -= 6;
        }

        if(otrava == true && !_audio.isPlaying && Gas_mask.nadevaem != 1)
        {
            Debug.Log("Amasu-A-Tikano");
            _audio.PlayOneShot(kashel);
          
        }*/
      if (otrava == true && Gas_mask.nadevaem != 1)
        {
            Pb.BarValue -= 0.5f;
        }
      if (otrava == true && !_audio.isPlaying && Gas_mask.nadevaem != 1)
        {
            Debug.Log("Amasu-A-Tikano");
            _audio.PlayOneShot(kashel);
        }

        else if(otrava == false || Gas_mask.nadevaem == 1)
        {
            _audio.Stop();
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            
            otrava = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
           
            otrava = false;
        }
    }
}
