using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas_bomb_attack : MonoBehaviour
{
    public GameObject BB2_;
    bool enter = false;
    float speed;
    public float time;
    public GameObject[] protivogas;
    public GameObject[] gas;
    public AudioSource _audio;
    public AudioClip boom;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (enter == false)
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        int K = 0;
        enter = true;
        yield return new WaitForSeconds(time);

        if(!BB2_.activeSelf && K == 0)
             BB2_.SetActive(true);

        speed = 15;
        gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
        for(int i = 0; i < protivogas.Length; i++)
        {
            protivogas[i].SetActive(true);
        }

        yield return new WaitForSeconds(5f);
        for(int i = 0; i < gas.Length; i++)
        {
            yield return new WaitForSeconds(1f); 
            gas[i].SetActive(true);
        }
        yield return new WaitForSeconds(5f);
        K = 1;
        BB2_.SetActive(false);

        yield return new WaitForSeconds(55f);
        for (int i = 0; i < gas.Length; i++)
        {
            yield return new WaitForSeconds(1f);
            gas[i].SetActive(false);
        }


    }
}
