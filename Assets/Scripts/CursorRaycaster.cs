using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorRaycaster : MonoBehaviour {
    
    [SerializeField] private float _maxDistance = 50f;
    
    private Camera _сamera;
    
    public event Action<RaycastHit> HitDetected;
    
    private void Awake()
    {
        _сamera = Camera.main;
    }

    public void Cast()
    {
        Ray ray = _сamera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out RaycastHit hit, _maxDistance))
        {
            HitDetected?.Invoke(hit);
        }
    }
}
