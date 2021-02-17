using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homebrew_Rigidbody : MonoBehaviour
{
    //We have a transform.position 
    // Vector 3 postion; 

    //We have time.fixedDeltaTime 
    // public float timePassed;

    public Vector3 velocity;

    public Vector3 acceleration;

    public Vector3 totalForce;

    public Vector3 gravity;

    public float mass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        totalForce += gravity;

        transform.position += velocity * Time.fixedDeltaTime;
        velocity += acceleration * Time.fixedDeltaTime;
        acceleration = totalForce / mass;

        totalForce = Vector3.zero; 
    }
}
