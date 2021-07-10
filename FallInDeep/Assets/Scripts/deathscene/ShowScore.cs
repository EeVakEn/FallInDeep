using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Start()
    {
        text.text = Public.score.ToString();
    }


}
