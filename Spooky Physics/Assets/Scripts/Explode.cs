using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject ExplosionPreFab;  // This is what you want the rocket to explode into

    public float ExplosionForce; // How far you want the explosion to travel 
    public float ExplosionDelay; // How long do you want the thing to wait to explode after being spawned
    private float explosionTime; // The sum of the total game time and the above variable 

    public Vector3 RocketForce; // How much power the rocket engine has 
    public float RocketDuration; // How long the rocket stays "on"
    private float rocketCutoffTime; // The sum of the total game time and the above variable 

    // Start is called before the first frame update
    void Start()
    {
        explosionTime = Time.time + ExplosionDelay;  // The equation that sets the variable!
        rocketCutoffTime = Time.time + RocketDuration; // This one too!
    }
    GameObject newExplosionPiece; // Time to prep the explosives!

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time < rocketCutoffTime)
        {
            GetComponent<Homebrew_Rigidbody>().totalForce += RocketForce; // FIRE UP THE ROCKET
        }

        if (Time.time > explosionTime) // Time for a cacophony of explosions
        {
            for (int i = 0; i < 30; i++)
            {
                newExplosionPiece = Instantiate(ExplosionPreFab); // Creates a piece of your explosion shrapnel
                newExplosionPiece.transform.position = this.transform.position; // Makes sure its starts in the same place as the rocket
                newExplosionPiece.GetComponent<Homebrew_Rigidbody>().velocity = this.GetComponent<Homebrew_Rigidbody>().velocity; // Gives it the same initial speed of the rocket
                newExplosionPiece.GetComponent<Homebrew_Rigidbody>().totalForce = ExplosionForce * Random.insideUnitCircle; // Makes the shrapnel travel in a random direction 
            }
            Destroy(this.gameObject); // The final straw, the end of the rocket
        }
    }
}
