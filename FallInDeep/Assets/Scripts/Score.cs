using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class Score : MonoBehaviour
{

    public TextMeshProUGUI text;
    public int score;
    public int speed = 1;
    private void Awake() {
        if(PlayerPrefs.HasKey("record")){
            Public.record = PlayerPrefs.GetInt("record");
        }
    }
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
        if(score > Public.record){
            Public.record = score;
            PlayerPrefs.SetInt("record",Public.record);
        }

    }
}
