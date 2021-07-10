using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowRecord : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Start()
    {   
        text.text = Public.record.ToString();
    }
}
