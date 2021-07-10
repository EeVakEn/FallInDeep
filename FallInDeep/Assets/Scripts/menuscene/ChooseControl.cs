using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseControl : MonoBehaviour
{
    private void Awake() {
        if(PlayerPrefs.HasKey("control")){
            Public.control = PlayerPrefs.GetInt("control");
        }
    }
    public static void ChangeControl(int control1){
        Public.control = control1;
        PlayerPrefs.SetInt("control",Public.control);

    }


}
