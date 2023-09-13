using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_StarMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    
}
