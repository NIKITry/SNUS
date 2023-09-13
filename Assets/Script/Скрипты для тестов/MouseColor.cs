using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseColor : MonoBehaviour
{
    public void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
