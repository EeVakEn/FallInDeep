using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseControl : MonoBehaviour
{
    private void Awake() {
        if(PlayerPrefs.HasKey("Control")){
            Public.control = PlayerPrefs.GetInt("Control");
        }
    }
    public static void ChangeControl(int control1){
        Public.control = control1;
        PlayerPrefs.SetInt("Control",control1);

    }


}
