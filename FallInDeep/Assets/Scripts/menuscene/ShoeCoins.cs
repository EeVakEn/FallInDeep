using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShoeCoins : MonoBehaviour
{
public TextMeshProUGUI text;
    void Update()
    {

        text.text = Public.coins.ToString();
    }
}
