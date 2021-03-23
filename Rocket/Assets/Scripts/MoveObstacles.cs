using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 1.5f;
    public float height = 5f;
    // Update is called once per frame
    void Update()
    {     
        Vector3 obs = this.transform.position;
        float newY = Mathf.Sin(Time.time * speed) * height;
        this.transform.position = new Vector3(obs.x, newY, obs.z);


        //if (obs.y < -2f)
        //{
        //    transform.Translate(Vector3.up * speed * Time.deltaTime);
        //}
        //transform.Translate(Vector3.down * speed * Time.deltaTime);
        //if (obs.y >= 0)
        //{
        //    transform.Translate(Vector3.down * speed * Time.deltaTime);
        //}


    }
}
