using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public List<GameObject> skins = new List<GameObject>();
    public List<GameObject> weapons = new List<GameObject>();
    private void Start()
    {
        
        for (int i = 0; i < skins.Count; i++)
        {   
            if(PlayerPrefs.GetInt("Skin")==i)
                skins[i].SetActive(true);
            else
                skins[i].SetActive(false);
        }
        for (int i = 0; i < weapons.Count; i++)
        {   
            if(PlayerPrefs.GetInt("Weapon")==i)
                weapons[i].SetActive(true);
            else
                weapons[i].SetActive(false);
        }
        
    }

}

