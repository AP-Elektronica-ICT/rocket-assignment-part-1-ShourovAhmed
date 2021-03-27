using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public int pointsPerCoin = 10;
    public int Score = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            Score += pointsPerCoin;
        }
    }
}
