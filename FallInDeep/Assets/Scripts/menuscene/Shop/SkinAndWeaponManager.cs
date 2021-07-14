using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class SkinAndWeaponManager : MonoBehaviour
{
    public Image srSkin;
    public Image srWeapon;
    public List<Sprite> skins = new List<Sprite>();
    public List<Sprite> weapons = new List<Sprite>();
    private int renderSkin;
    private int renderWeapon;
    private void Start()
    {
        if (PlayerPrefs.HasKey("Skin"))
        {
            renderSkin = PlayerPrefs.GetInt("Skin");
            srSkin.sprite = skins[renderSkin];
        }
        else
        {
            renderSkin = 0;
            srSkin.sprite = skins[renderSkin];
        }

        if (PlayerPrefs.HasKey("Weapon"))
        {
            renderSkin = PlayerPrefs.GetInt("Weapon");
            srWeapon.sprite = weapons[renderWeapon];
        }
        else
        { 
            renderSkin = 0;
            srWeapon.sprite = weapons[renderWeapon];
        }
       
    }
    
    public void NextSkin()
    {
        renderSkin += 1;
        if (renderSkin == skins.Count)
        {
            renderSkin = 0;
        }
        srSkin.sprite = skins[renderSkin];
    }
    public void BackSkin()
    {
        renderSkin -= 1;
        if (renderSkin < 0)
        {
            renderSkin = skins.Count - 1;
        }
        srSkin.sprite = skins[renderSkin];
    }
    public void NextWeapon()
    {
        renderWeapon += 1;
        if (renderWeapon == weapons.Count)
        {
            renderWeapon = 0;
        }
        srWeapon.sprite = weapons[renderWeapon];
    }
    public void BackWeapon()
    {
        renderWeapon -= 1;
        if (renderWeapon < 0)
        {
            renderWeapon = weapons.Count - 1;
        }
        srWeapon.sprite = weapons[renderWeapon];
    }
    public void SelectSkin()
    {
        PlayerPrefs.SetInt("Skin", renderSkin);
    }
    public void SelectWeapon()
    {
        PlayerPrefs.SetInt("Weapon", renderWeapon);
    }
}
