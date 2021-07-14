using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowCoins : MonoBehaviour
{
public TextMeshProUGUI text;
    void Update()
    {
        text.text = PlayerPrefs.GetInt("coins").ToString();
    }
}
