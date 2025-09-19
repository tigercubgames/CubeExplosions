using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    [SerializeField] private float _force = 200f;
    [SerializeField] private float _radius = 2f;

    public void BlowUp(Vector3 position, List<Cube> cubes)
    {
        foreach (Cube cube in cubes)
        {
            Rigidbody rigidbody = cube.GetRigidbody();
            rigidbody.AddExplosionForce(_force, position, _radius);
        }
    }
}
