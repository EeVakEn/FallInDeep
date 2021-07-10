using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RecordShow : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Start()
    {   
        if(Public.record==Public.score){
            text.text = "New!!! \n" + Public.record.ToString();
        }else{
            text.text = Public.record.ToString();
        }
        
    }

}
