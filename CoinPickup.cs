using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int currentCoin = 0;
    public int totalScore = 0;
    public TextMeshProUGUI TMPScore;

    private Dictionary<string, int> coinValues = new Dictionary<string, int>();

    void Start()
    {
        TMPScore.text = (totalScore).ToString();
        coinValues.Add("gold",10);
        coinValues.Add("silver", 5);
        coinValues.Add("bronze", 3);
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Coin")
        {
            string coinType = other.gameObject.name.ToLower();

            if (coinValues.ContainsKey(coinType))
            {
                currentCoin = coinValues[coinType];
            }
            
            totalScore += currentCoin;
            TMPScore.text = (totalScore).ToString();
            Destroy(other.gameObject);
        }
        
    }

}
