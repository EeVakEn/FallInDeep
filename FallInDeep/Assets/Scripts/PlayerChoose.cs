using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChoose : MonoBehaviour
{
    public GameObject char1, char2;


    void Start()
    {
        if(Public.charOn == 1){
            char1.gameObject.SetActive(true);
            char2.gameObject.SetActive(false);
        }else if(Public.charOn == 2){
            char1.gameObject.SetActive(false);
            char2.gameObject.SetActive(true);
        }
            
    }
}
