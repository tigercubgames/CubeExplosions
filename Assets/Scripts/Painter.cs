using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painter : MonoBehaviour
{
    public void RepaintRandomColor()
    {
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
