using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    [SerializeField] private ClickDetector _clickDetector;
    [SerializeField] private CursorRaycaster _cursorRaycaster;
    
    private void OnEnable()
    {
        _clickDetector.Clicked += _cursorRaycaster.Cast;
    }

    private void OnDisable()
    {
        _clickDetector.Clicked -= _cursorRaycaster.Cast;
    }
}
