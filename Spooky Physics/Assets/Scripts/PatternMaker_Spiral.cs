using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternMaker_Straight: MonoBehaviour
{
    public GameObject objectToClone;

    public int numOfClones;

    public float stepSize;
    public float turnSizeInDegrees;
    public int nSteps; 

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObject;

        for(int stepNumber = 0; stepNumber < nSteps; stepNumber++)
        {
            newObject = Instantiate(objectToClone);

            newObject.transform.position = transform.position;

            this.transform.position += transform.TransformVector (Vector3.right);

            this.transform.localEulerAngles += new Vector3(0, 0, turnSizeInDegrees);

        }
    }

}
