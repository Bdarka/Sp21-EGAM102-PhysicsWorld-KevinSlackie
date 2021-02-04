using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string outputString = "";
        string outputString2 = "";
        string outputString3 = "";
        string outputString4 = "";

        for(int i = -100; i < 101; i++)
        {
            outputString += i.ToString() + ", ";
            if(i % 2 == 0)
            {
                i++;
            }
        }

        Debug.Log(outputString);

        bool isPrime = true;

        for (int i = 0; i < 501; i++)
        {

            for (int j = 2; j < 101; j++)
            {
                if (i != j && i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
            {
                outputString2 += i.ToString() + ", ";
            }
            isPrime = true;
        }

        Debug.Log(outputString2);

        for(int i = 55; i < 256; i++)
        {
            if(i % 5 == 0)
            {
                outputString3 += i.ToString() + ", ";
            }
        }

        Debug.Log(outputString3);

        for (int i = 1; i < 100; i++)
        {
            
            if (i % 2 != 0)
            {
                outputString4 += i.ToString() + ", ";
            }
        }
        Debug.Log(outputString4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
