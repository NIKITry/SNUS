using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_in_test : MonoBehaviour
{
    string pupa() 
    {
        return "Lupa";
    }
    string lupa() 
    {
        return "Pupa";
    }
        void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
