using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private const string PrefabName = "Cube";
    
    [SerializeField] private Transform _parentTransform;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _minCount = 2;
    [SerializeField] private int _maxCount = 6;
    [SerializeField] private float _scaleRatio = 0.5f;
    [SerializeField] private float _randomRatio = 0.5f;

    private List<GameObject> _spawnedObjects = new List<GameObject>();
    
    public float CurrentChance { get; private set; } = 1f;

    private void Awake()
    {
        _prefab = Resources.Load<GameObject>(PrefabName);
    }
    
    public bool TrySpawn()
    {
        if (Random.value <= CurrentChance)
        {
            SpawnMultiple();
            
            return true;
        }

        return false;
    }

    public List<GameObject> GetSpawnedObjects()
    {
        return _spawnedObjects;
    }
    
    private void SpawnMultiple()
    {
        int count = Random.Range(_minCount, _maxCount + 1);
        
        for (int i = 0; i < count; i++)
        {
            Spawn();
        }
    }
    
    private void Spawn()
    {
        GameObject newGameObject = InstantiateObject();
        SetScale(newGameObject);
        SetSpawnChance(newGameObject);
        RegisterSpawnedObject(newGameObject);
    }
    
    private void RegisterSpawnedObject(GameObject gameObject)
    {
        _spawnedObjects.Add(gameObject);
    }
    
    private GameObject InstantiateObject()
    {
        return Instantiate(_prefab, _parentTransform.position, Quaternion.identity);
    }
    
    private void SetScale(GameObject gameObject)
    {
        gameObject.transform.localScale = _parentTransform.localScale * _scaleRatio;
    }
    
    private void SetChance(float value)
    {
        CurrentChance = value;
    }
    
    private void SetSpawnChance(GameObject gameObject)
    {
        Spawner newSpawner = gameObject.GetComponent<Spawner>();
        newSpawner.SetChance(CurrentChance * _randomRatio);
    }
}
