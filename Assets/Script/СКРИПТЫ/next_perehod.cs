using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_perehod : MonoBehaviour
{
    [Header("Индекс сцены")]
    public int sceneIndex;

    void Next()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
