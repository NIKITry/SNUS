using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasMaskChoise : MonoBehaviour
{
    public GameObject gasMaskChoise;
    public FirstPersonController FPS;
    public Text inputField, outputField;

    bool enter;

    void Update()
    {
        if (enter)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            enter = true;
            FPS.setFreeze(true);
            gasMaskChoise.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            
        }
    }

    public void Continious()
    {
   
        enter = false;
        gasMaskChoise.SetActive(false);
        FPS.setFreeze(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

        public void Calculate()
    {
float result = 0;
float inputNumber = float.Parse(inputField.text);

if(inputNumber >= 100 && inputNumber < 121){
    result = 1;
} else if(inputNumber >= 121 && inputNumber < 124){
    result = 2;
} else if(inputNumber >= 124 && inputNumber < 160){
    result = 3;
} else {
    outputField.text = "Неверные измерения";
    return;
}

outputField.text = result.ToString();
    }
}

