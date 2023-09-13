using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TP : MonoBehaviour
{
    public static bool tp_razvertca = false;

    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "kuzov")
        {
            tp_razvertca = true;
            SceneManager.LoadSceneAsync("twoIndividRuning");
        }
    }
}
