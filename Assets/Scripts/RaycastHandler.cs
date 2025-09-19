using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHandler : MonoBehaviour
{
    [SerializeField] private CursorRaycaster _cursorRaycaster;
    [SerializeField] private CubeSpawner _cubeSpawner;
    [SerializeField] private Exploder _exploder;
    
    private void OnEnable()
    {
        _cursorRaycaster.HitDetected += OnClicked;
    }

    private void OnDisable()
    {
        _cursorRaycaster.HitDetected -= OnClicked;
    }

    private void OnClicked(RaycastHit hit)
    {
        GameObject target = hit.collider.gameObject;

        if (target.TryGetComponent<Cube>(out Cube cube))
        {
            if (Random.value <= cube.GetSplitChance())
            {
                List<Cube> newCubes = _cubeSpawner.SpawnCubes(cube);

                _exploder.BlowUp(cube.transform.position, newCubes);
            }

            Destroy(cube.gameObject);
        }
    }
}
