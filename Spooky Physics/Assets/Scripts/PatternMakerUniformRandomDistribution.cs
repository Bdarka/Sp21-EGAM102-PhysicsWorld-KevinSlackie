using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternMakerUniformRandomDistribution : MonoBehaviour
{
    public GameObject objectToClone;

    public int numOfClones;

    public float xMin, xMax, yMin, yMax;
    public float cloneScaleMin, cloneScaleMax;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObject; 

        for(int i = 0; i < numOfClones; i++)
        {
            newObject = Instantiate(objectToClone, this.transform);

            newObject.transform.position = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);

            newObject.transform.localScale = Random.Range(cloneScaleMin, cloneScaleMax) * Vector3.one;

        }
    }

}
