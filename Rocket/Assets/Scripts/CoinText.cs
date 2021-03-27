using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    private Text scoreBox;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        scoreBox = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Rocket");
    }

    // Update is called once per frame
    void Update()
    {
        scoreBox.text = "Score: " + player.GetComponent<CoinScore>().Score;
    }
}
