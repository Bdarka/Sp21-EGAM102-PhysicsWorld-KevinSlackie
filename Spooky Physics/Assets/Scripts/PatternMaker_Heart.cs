using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternMaker_Heart: MonoBehaviour
{
    public GameObject objectToClone;

    public float x, y;

    public float turnSizeInDegrees;
    public float stepSize;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObject;
   
        for(int i = 0; i < 5; i++)
        {
            newObject = Instantiate(objectToClone);

            newObject.transform.position = transform.position;

            this.transform.position += stepSize * transform.TransformVector (Vector3.left);

            this.transform.localEulerAngles += new Vector3(0, 0, (turnSizeInDegrees - 1));

            turnSizeInDegrees *= .99f;

        }
    }

}
