using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string outputString = "";

        for(int i = 1; i < 101; i++)
        {
            outputString += i.ToString() + ", ";
        }

        Debug.Log(outputString);

;    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
