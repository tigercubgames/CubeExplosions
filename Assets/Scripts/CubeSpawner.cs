using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Cube _parent;
    [SerializeField] private int _minCount = 2;
    [SerializeField] private int _maxCount = 6;
    [SerializeField] private float _scaleRatio = 0.5f;

    public List<Cube> SpawnCubes(Cube parentCube)
    {
        List<Cube> cubes = new List<Cube>();
        int count = Random.Range(_minCount, _maxCount + 1);
        float nextChanceSplit = parentCube.GetNextSplitChance();
        
        for (int i = 0; i < count; i++)
        {
            Cube newCube = Instantiate(_parent, parentCube.transform.position, Quaternion.identity);
            newCube.transform.localScale = parentCube.transform.localScale * _scaleRatio;
            newCube.SetSplitChance(nextChanceSplit);

            cubes.Add(newCube);
        }
        
        return cubes;
    }
}
