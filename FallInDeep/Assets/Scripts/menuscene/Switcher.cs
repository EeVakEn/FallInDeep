using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
 
    private void Awake() {
        if(PlayerPrefs.HasKey("charOn")){
            Public.charOn = PlayerPrefs.GetInt("charOn");
        }
        if(PlayerPrefs.HasKey("weaponOn")){
            Public.weaponOn = PlayerPrefs.GetInt("weaponOn");
        }
    }
    public void SwitchCharacter(int charOn){
        Public.charOn = charOn;
        PlayerPrefs.SetInt("charOn",Public.charOn);
    }
    
    public void SwitchWeapon(int weaponOn){
        Public.weaponOn = weaponOn;
        PlayerPrefs.SetInt("weaponOn",Public.weaponOn);
    }

}
