using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[AddComponentMenu ("My components/perehod")]
public class perehod : MonoBehaviour
{
    [Header("Индекс сцены")]
    public int sceneIndex;

    public GameObject loot_box;
    public GameObject fps;
    public GameObject cam_in_box;
    public GameObject music;

    /*void Next()
    {
        SceneManager.LoadScene(sceneIndex);
    }*/

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            BiG_Quest.tmp++;
            fps.SetActive(false);
            cam_in_box.SetActive(true);
            loot_box.GetComponent<Animator>().enabled = true;
            music.SetActive(true);
            
         
        }
            
    }
  
   
}
