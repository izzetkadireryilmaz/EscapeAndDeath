using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinController : MonoBehaviour
{
    public int Coin;
    public TextMeshProUGUI tm;

    void Start()
    {
        Coin = PlayerPrefs.GetInt("Coin");
    }

 
    void Update()
    {
        tm.text = Coin.ToString();
        PlayerPrefs.SetInt("Coin", Coin);
    }
}
