using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    private int _buttonNumber = 0;
    public event Action Clicked;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(_buttonNumber))
        {
            Clicked?.Invoke();
        }
    }
}
