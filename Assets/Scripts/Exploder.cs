using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private int _force = 450;
    [SerializeField] private int _radius = 4;
    
    public void BlowUp()
    {
        List<GameObject> targetList = _spawner.GetSpawnedObjects();

        if (targetList.Count == 0)
            return;
        
        foreach (var target in targetList)
        {
            target.GetComponent<Rigidbody>().AddExplosionForce(_force, transform.position, _radius);
        }
    }
}
