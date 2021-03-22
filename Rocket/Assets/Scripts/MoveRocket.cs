using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRocket : MonoBehaviour
{
    private Rigidbody rocket;
    // Start is called before the first frame update  
    void Start()
    {
        rocket = GetComponent<Rigidbody>();
    }
    Vector3 Vec;
    
    public int force = 5;
    public float left = -1f;
    public float right = 1f;
    //public int speed = 20;
    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //rocket.AddForce(transform.up * force);
            rocket.AddRelativeForce(transform.up * force);
        }          
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rocket.transform.Rotate(left, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rocket.transform.Rotate(right,0f,0f);
        }

        
        
        //Vec = transform.localPosition;        
        //Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //Vec.y += Input.GetAxis("Jump") * Time.deltaTime * speed;
        //Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * speed;
        //transform.localPosition = Vec;
    }
}
