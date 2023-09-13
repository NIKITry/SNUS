using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinesPlaneTriggers : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Techis;
    public AudioSource MySourse;
    public AudioClip[] Audio_mesh;
    public static bool DeaDMan;
    int i = 0;
    public void Start()
    {
        DeaDMan = false;
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            DeaDMan = true;
            MySourse.PlayOneShot(Audio_mesh[i]);
            StartCoroutine(Zvuk());
        }
    }

    IEnumerator Zvuk()
    {
        Techis.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        Techis.SetActive(false);
        this.gameObject.SetActive(false);

    }
}