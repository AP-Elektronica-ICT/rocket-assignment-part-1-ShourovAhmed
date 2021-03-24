using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LandOnPlatform : MonoBehaviour
{
    public string LevelToLoad;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            //System.Threading.Thread.Sleep(1000);
            SceneManager.LoadScene(LevelToLoad);
        }
    }

}
