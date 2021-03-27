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
            Destroy(other.gameObject);
            //other.gameObject.SetActive(false); --> omdat we meer dan 1 collider op rocket hadden (op de child components ervan), kregen we meer score
            Score += pointsPerCoin;
        }
    }
}
