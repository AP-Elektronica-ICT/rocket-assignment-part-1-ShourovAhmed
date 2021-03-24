using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
    public GameObject player;
    public GameObject LevelCompleteCanvas;

    private bool Landed;
    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Rocket");
        }
        body = player.GetComponent<Rigidbody>();

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
            player.SetActive(false);

            
        }
    }
}
