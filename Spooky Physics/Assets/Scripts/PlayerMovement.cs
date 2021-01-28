using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float moveSpeed = 10, jumpStrength = 10;

    float moveH;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(jumpStrength * Vector3.up, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveH, 0);
        rigidbody.AddForce(movement * moveSpeed);
    }
}
