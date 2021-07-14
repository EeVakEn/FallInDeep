using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RecordShow : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Start()
    {   
        if(PlayerPrefs.GetInt("record")==Public.score){
            text.text = "New!!! \n" + PlayerPrefs.GetInt("record").ToString();
        }else{
            text.text = PlayerPrefs.GetInt("record").ToString();
        }
        
    }

}
