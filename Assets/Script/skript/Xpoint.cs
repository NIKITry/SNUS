using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xpoint : MonoBehaviour
{
  public Text txt_xp;

    // Update is called once per frame
    void Update()
    {
         txt_xp.text = "Опыт: " + health.xp;
    }
}
