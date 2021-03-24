using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    private Text healthBox;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        healthBox = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Rocket");
    }

    // Update is called once per frame
    void Update()
    {
        healthBox.text = "Health: " + player.GetComponent<Health>().healthPoints;
    }
}
