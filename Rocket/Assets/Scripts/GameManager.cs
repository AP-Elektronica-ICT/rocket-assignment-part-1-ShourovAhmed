using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameObject player;
    public GameObject homeScreenCanvas;
    public GameObject gameOverCanvas;

    //private Health healthPlayer;

    public enum GameStates { Playing, GameOver}
    public GameStates gameState = GameStates.Playing;

    // Start is called before the first frame update
    void Start()
    {
        homeScreenCanvas.SetActive(true);
        //if (player == null)
        //{
        //    player = GameObject.FindGameObjectWithTag("Player");
        //}
        //healthPlayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        //state Machine of the game

        //switch (gameState)
        //{
        //    case GameStates.Playing:
        //        if (!healthPlayer.isAlive)
        //        {
        //            gameState = GameStates.GameOver;
        //            mainCanvas.SetActive(false);
        //            gameOverCanvas.SetActive(true);
        //        }
        //        else
        //            gameOverCanvas.SetActive(false);
        //        break;

        //    case GameStates.GameOver:
        //        break;
        //    default:
        //        break;
        //}
    }
}
