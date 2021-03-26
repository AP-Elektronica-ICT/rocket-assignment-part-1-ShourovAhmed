using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrafeRocket : MonoBehaviour
{
    private Rigidbody rocket;
    // Start is called before the first frame update  
    void Start()
    {
        rocket = GetComponent<Rigidbody>();
    }

    public int force = 10;
    public int speed = 10;

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rocket.AddRelativeForce(transform.up * force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rocket.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rocket.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
     
        //Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //Vec.y += Input.GetAxis("Jump") * Time.deltaTime * speed;
        //Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * speed;
        //transform.localPosition = Vec;
    }
}
