using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatforms : MonoBehaviour
{
    private Vector3 startPositon;
    // Start is called before the first frame update
    void Start()
    {
        startPositon = transform.position;
    }

    public float speed = 1.5f;
    public float width = 10f;

    // Update is called once per frame
    void Update()
    {
        Vector3 platform = transform.position;
        float newX = Mathf.Sin(Time.time * speed) * width;
        this.transform.position = new Vector3(newX, platform.y, platform.z);
    }

    // TODO

    //public float speed = 1.5f;
    //public float width = 10f;
    //public float timePeriod = 2;
    //private float timeSinceStart;
    //private Vector3 pivot;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    pivot = transform.position;
    //    width /= 2;
    //    timeSinceStart = (3 * timePeriod) / 4;
    //}



    //// Update is called once per frame
    //void Update()
    //{
    //    Vector3 nextPos = transform.position;
    //    nextPos.x = pivot.x + width + width * Mathf.Sin(((Mathf.PI * 2) / timePeriod) * timeSinceStart);
    //    timeSinceStart += Time.deltaTime;
    //    transform.position = nextPos;
    //}
}
