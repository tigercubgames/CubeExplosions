using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Renderer))]

public class RandomColorSetter : MonoBehaviour
{
    private void Start()
    {
        Set();
    }

    private void Set()
    {
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
