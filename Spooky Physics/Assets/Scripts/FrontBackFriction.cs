using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontBackFriction : MonoBehaviour
{
    public string NameofDragger;  // Very iffy variable name that means "what object am I reacting to
    public float Drag;

    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); // Get the component so that this can use the Unity physics engine 
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == NameofDragger) //Here's the meat: what the program should do when A meets B
        {
            Vector3 velocityOfDragger = collision.gameObject.GetComponent<Rigidbody2D>().velocity;  // Get the velocity of the game object I collided with
            rigidbody2D.AddForce(Drag * velocityOfDragger);  // Add that velocity to me so I react to the other Game Object 
        }
    }
}
