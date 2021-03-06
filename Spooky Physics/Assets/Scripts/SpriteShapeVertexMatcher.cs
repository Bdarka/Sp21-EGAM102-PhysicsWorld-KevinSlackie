﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SpriteShapeVertexMatcher : MonoBehaviour
{
    public Transform[] cornerObjects;

    private SpriteShapeController spriteShapeController;

    // Start is called before the first frame update
    void Start()
    {
        spriteShapeController = GetComponent<SpriteShapeController>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int pointID = 0; pointID < cornerObjects.Length; pointID++)
        {
            spriteShapeController.spline.SetPosition(pointID, cornerObjects[pointID].localPosition);

        }
    }
}
