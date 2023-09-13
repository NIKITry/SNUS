using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatalPoint : MonoBehaviour
{
    public Text name;
    public Text fename;
    public Text xp;
    public Text lvl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        name.text = FIO.a;
        fename.text = FIO.b;
        xp.text = "Опыт: " + health.xp;
        lvl.text = "Уровень: " + health.lvl;

    }
}
