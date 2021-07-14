using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseControl : MonoBehaviour
{
    public static void ChangeControl(int control1){
        PlayerPrefs.SetInt("Control",control1);
    }
}
