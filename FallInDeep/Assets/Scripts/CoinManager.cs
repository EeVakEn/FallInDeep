using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public TextMeshProUGUI text;
    private int coins;

    private void Awake()
    {
        instance = this;
        if (PlayerPrefs.HasKey("coins"))
        {
            coins = PlayerPrefs.GetInt("coins");
        }

    }
    void Start()
    {
        if (PlayerPrefs.HasKey("coins"))
        {
            coins = PlayerPrefs.GetInt("coins");
            text.text = "x" + PlayerPrefs.GetInt("coins");
        }
    }
    public void ChangeScore(int coinValue)
    {
        coins += coinValue;
        text.text = "x" + PlayerPrefs.GetInt("coins");
        PlayerPrefs.SetInt("coins", coins);
    }

}
