using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FIO : MonoBehaviour
{
 public static string a;
 public static string b;
 public InputField InFename;
 public InputField InName;
 int k = 0;
 public Text ShowFename;
 public Text ShowName;


 public void Next(){
if(k == 0){
 a = InFename.text;
 b = InName.text;
k++;
}
 

}
void Update(){
ShowFename.text = a;
 ShowName.text = b;
}

}
