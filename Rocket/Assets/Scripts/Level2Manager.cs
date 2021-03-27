using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Manager : MonoBehaviour
{
    public GameObject player;
    public GameObject LevelCompleteCanvas;

    private bool Landed;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Rocket");
        }


        Landed = player.gameObject.GetComponent<Health>().landed;
        LevelCompleteCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Landed = player.gameObject.GetComponent<Health>().landed;

        if (Landed)
        {
            LevelCompleteCanvas.SetActive(true);

            // Make Rocket disappear
            player.SetActive(false);


        }
    }
}
