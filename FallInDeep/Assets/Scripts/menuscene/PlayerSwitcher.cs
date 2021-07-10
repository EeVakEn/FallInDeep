using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitcher : MonoBehaviour
{
 
    private void Awake() {
        if(PlayerPrefs.HasKey("charOn")){
            Public.charOn = PlayerPrefs.GetInt("charOn");
        }
    }
    public void SwitchCharacter(int charOn){
        Public.charOn = charOn;
        PlayerPrefs.SetInt("charOn",Public.charOn);
    }

}
