using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Cube : MonoBehaviour
{
    [SerializeField] private float _splitChance = 1f;
    [SerializeField] private float _randomSplitRatio = 0.5f;
    
    private Rigidbody _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public float GetSplitChance()
    {
        return _splitChance;
    }

    public float GetNextSplitChance()
    {
        return _splitChance * _randomSplitRatio;
    }

    public void SetSplitChance(float chance)
    {
        _splitChance = chance;
    }
    
    public Rigidbody GetRigidbody()
    {
        return _rigidbody;
    }
}
