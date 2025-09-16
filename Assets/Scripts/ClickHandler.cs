using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public event Action Clicked;
    
    private void OnMouseUpAsButton()
    {
        Clicked?.Invoke();
    }
}
