using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class Score : MonoBehaviour
{

    public TextMeshProUGUI text;
    private int score;
    public int speed = 1;

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score += Convert.ToInt32(speed);
        text.text = score.ToString();
        Public.score = score;
        if(score > PlayerPrefs.GetInt("record")){
            PlayerPrefs.SetInt("record",score);
        }

    }
}
