using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    [SerializeField] private ClickHandler _clickHandler;
    [SerializeField] private Destroyer _destroyer;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private StartHandler _startHandler;
    [SerializeField] private Painter _painter;
    [SerializeField] private Exploder _exploder;

    private void OnEnable()
    {
        _startHandler.Started += _painter.RepaintRandomColor;
        _clickHandler.Clicked += OnClicked;
    }

    private void OnDisable()
    {
        _startHandler.Started -= _painter.RepaintRandomColor;
        _clickHandler.Clicked -= OnClicked;
    }
    
    private void OnClicked()
    {
        if (_spawner.TrySpawn())
        {
            _exploder.BlowUp();
            _destroyer.HideAndDestroyDelayed();
        }
        else
        {
            _destroyer.HideAndDestroyDelayed();
        }
    }
}
