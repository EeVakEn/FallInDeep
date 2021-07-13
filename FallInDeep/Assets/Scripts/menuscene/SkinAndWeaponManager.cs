using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class SkinAndWeaponManager : MonoBehaviour
{
    public SpriteRenderer srWeapon;
    public SpriteRenderer srSkin;
    public List<Sprite> skins = new List<Sprite>();
    public List<Sprite> weapons = new List<Sprite>();
    private int selectedSkin = 0;
    private int selectedWeapon = 0;

    public void NextSkin()
    {
        selectedSkin +=1;
        if(selectedSkin == skins.Count){
            selectedSkin = 0;
        }
        srSkin.sprite = skins[selectedSkin];
    }
    public void BackSkin()
    {
        selectedSkin -=1;
        if(selectedSkin <0){
            selectedSkin = skins.Count-1;
        }
        srSkin.sprite = skins[selectedSkin];
    }
    public void NextWeapon()
    {
        selectedWeapon +=1;
        if(selectedWeapon == weapons.Count){
            selectedWeapon = 0;
        }
        srWeapon.sprite = weapons[selectedWeapon];
    }
    public void BackWeapon()
    {
        selectedWeapon -=1;
        if(selectedWeapon <0){
            selectedWeapon = weapons.Count-1;
        }
        srWeapon.sprite = weapons[selectedWeapon];
    }
    public void SelectSkin(){
        PlayerPrefs.SetInt("Skin",selectedSkin);
    }
    public void SelectWeapon(){
        PlayerPrefs.SetInt("Weapon",selectedWeapon);
    }
}
