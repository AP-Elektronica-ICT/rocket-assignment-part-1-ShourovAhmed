using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatforms : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 1.5f;
    public float width = 10f;

    // Update is called once per frame
    void Update()
    {
        Vector3 platform = this.transform.position;
        float newX = Mathf.Sin(Time.time * speed) * width;
        this.transform.position = new Vector3(newX, platform.y, platform.z);
    }
}
