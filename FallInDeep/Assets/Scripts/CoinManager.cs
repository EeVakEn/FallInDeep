using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public TextMeshProUGUI text;

    private void Awake() {
        instance = this;
        if(PlayerPrefs.HasKey("coins")){
            Public.coins = PlayerPrefs.GetInt("coins");
        }
        
    }
    void Start()
    {
        text.text = "x"+ Public.coins.ToString();
    }
    public void ChangeScore(int coinValue){
        Public.coins+=coinValue;
        text.text = "x"+ Public.coins.ToString();
        PlayerPrefs.SetInt("coins",Public.coins);
    }

}
