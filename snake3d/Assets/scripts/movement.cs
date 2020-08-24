using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float dir;
    public float speed=10f;
    public float rotSpeed=10f;
    //bool ground=false;
   public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        dir=Input.GetAxis("Horizontal");
       

        
    }
    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        
        move();
       
       }
    void move(){
        rb.velocity=transform.forward*Time.fixedDeltaTime*speed;
        transform.Rotate(Vector3.up*dir*Time.fixedDeltaTime*rotSpeed);

    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
   
}
